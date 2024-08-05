require('dotenv').config();

const sequelize = require('./lib/database');
const { Save, File } = require('./models');
const discord = require('./lib/discord');

const express = require('express');
const cors    = require('cors');

const app = express();

app.use(cors());

app.use(express.json());
app.use(express.urlencoded({ extended: false }));

app.use('/', express.static('public')); // TODO: Host UI from here perhaps?

const port = process.env.PORT || 3000;
const interface = process.env.INTERFACE || 'localhost';
const apiPrefix = process.env.API_PREFIX || '';

app.use((req, res, next) => { // TODO: Proper logging
  console.log(`${req.method} ${req.url}`);
  next();
});

app.use((err, req, res, next) => {
  console.log(`Error: ${err}`);
  console.error(err.stack);

  discord.send(`[${req.method}] ${req.url} Error: ${err}`);

  res.status(500).send('Something broke!');
});

app.get(`${apiPrefix}`, (req, res) => {
  res.json({
    message: "Welcome to the MapsNotIncluded API"
  });
});

app.use(`${apiPrefix}/saves`, require('./controllers/Save'));
app.use(`${apiPrefix}/files`, require('./controllers/File'));
app.use(`${apiPrefix}/ingest`, require('./controllers/Ingest'));

app.listen(port, interface, () => {
    console.log(`Server is running on port http://${interface}:${port} with prefix ${apiPrefix}`);
});