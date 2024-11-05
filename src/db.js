// Mock database module

module.exports = {
  query: jest.fn().mockResolvedValue({ rows: [] }),
};
