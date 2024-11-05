const express = require('express');
const router = express.Router();

// Mock data for demonstration purposes
let specificationValues = [];

// GET /specification-values
router.get('/', (req, res) => {
  res.json({ data: specificationValues });
});

// POST /specification-values
router.post('/', (req, res) => {
  const { name, value } = req.body;
  if (!name || !value) {
    return res.status(400).json({ error: 'Name and value are required.' });
  }
  const newSpecValue = { id: specificationValues.length + 1, name, value };
  specificationValues.push(newSpecValue);
  res.status(201).json(newSpecValue);
});

// PUT /specification-values/:id
router.put('/:id', (req, res) => {
  const { id } = req.params;
  const { name, value } = req.body;
  const specValue = specificationValues.find(sv => sv.id === parseInt(id));
  if (!specValue) {
    return res.status(404).json({ error: 'Specification value not found.' });
  }
  if (name) specValue.name = name;
  if (value) specValue.value = value;
  res.json(specValue);
});

module.exports = router;
