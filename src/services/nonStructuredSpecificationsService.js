const db = require('../db'); // hypothetical database module

async function getAllSpecifications() {
  try {
    const result = await db.query('SELECT * FROM non_structured_specifications');
    return result.rows;
  } catch (error) {
    throw new Error('Database query failed');
  }
}

async function deleteSpecification(id) {
  try {
    await db.query('DELETE FROM non_structured_specifications WHERE id = $1', [id]);
  } catch (error) {
    throw new Error('Database query failed');
  }
}

module.exports = {
  getAllSpecifications,
  deleteSpecification,
};
