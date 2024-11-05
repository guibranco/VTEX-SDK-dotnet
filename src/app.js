const express = require('express');
const app = express();

const nonStructuredSpecificationsController = require('./controllers/nonStructuredSpecificationsController');

app.use('/non-structured-specifications', nonStructuredSpecificationsController);

const PORT = process.env.PORT || 3000;
app.listen(PORT, () => {
  console.log(`Server is running on port ${PORT}`);
});

