const request = require('supertest');
const express = require('express');
const nonStructuredSpecificationsService = require('../src/services/nonStructuredSpecificationsService');

const app = express();
app.use('/non-structured-specifications', nonStructuredSpecificationsController);

describe('Non Structured Specifications API', () => {
  it('should retrieve all non structured specifications', async () => {
    const response = await request(app).get('/non-structured-specifications');
    expect(response.statusCode).toBe(200);
    expect(Array.isArray(response.body)).toBe(true);
  });

  it('should delete a non structured specification', async () => {
    const idToDelete = 1; // Example ID
    const response = await request(app).delete(`/non-structured-specifications/${idToDelete}`);
    expect(response.statusCode).toBe(204);
  });

  it('should return 500 if deletion fails', async () => {
    const invalidId = 'invalid-id';
    const response = await request(app).delete(`/non-structured-specifications/${invalidId}`);
    expect(response.statusCode).toBe(500);
    expect(response.body.error).toBe('Failed to delete specification');
  });

  it('should return 500 if retrieval fails', async () => {
    jest.spyOn(nonStructuredSpecificationsController, 'getAllSpecifications').mockImplementation(() => {
      throw new Error('Database query failed');
    });
    const response = await request(app).get('/non-structured-specifications');
    expect(response.statusCode).toBe(500);
    expect(response.body.error).toBe('Failed to retrieve specifications');
  });
});
