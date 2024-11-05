const express = require('express');
const bodyParser = require('body-parser');
const specificationValuesRouter = require('./api/specificationValues');

const app = express();

// Middleware
app.use(bodyParser.json());

// Routes
app.use('/specification-values', specificationValuesRouter);

// Error handling middleware
app.use((err, req, res, next) => {
  console.error(err.stack);
  res.status(500).send('Something broke!');
});

module.exports = app;
