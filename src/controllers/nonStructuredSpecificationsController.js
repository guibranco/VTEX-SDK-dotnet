const express = require('express');
const router = express.Router();
const nonStructuredSpecificationsService = require('../services/nonStructuredSpecificationsService');

// GET /non-structured-specifications
router.get('/', async (req, res) => {
  try {
    const specifications = await nonStructuredSpecificationsService.getAllSpecifications();
    res.json(specifications);
  } catch (error) {
    res.status(500).json({ error: 'Failed to retrieve specifications' });
  }
});

// DELETE /non-structured-specifications/:id
router.delete('/:id', async (req, res) => {
  try {
    await nonStructuredSpecificationsService.deleteSpecification(req.params.id);
    res.status(204).send();
  } catch (error) {
    res.status(500).json({ error: 'Failed to delete specification' });
  }
});

module.exports = router;
