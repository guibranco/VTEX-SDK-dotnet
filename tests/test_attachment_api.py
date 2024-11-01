import unittest
from src.api import app

class TestAttachmentAPI(unittest.TestCase):

    def setUp(self):
        self.app = app.test_client()
        self.app.testing = True

    def test_create_attachment(self):
        response = self.app.post('/attachments', json={
            'item_id': 'item1',
            'attachment': {'key': 'value'}
        })
        self.assertEqual(response.status_code, 201)
        self.assertIn('Attachment created', response.get_data(as_text=True))

    def test_get_attachment(self):
        self.app.post('/attachments', json={
            'item_id': 'item2',
            'attachment': {'key': 'value'}
        })
        response = self.app.get('/attachments/item2')
        self.assertEqual(response.status_code, 200)
        self.assertIn('key', response.get_data(as_text=True))

    def test_update_attachment(self):
        self.app.post('/attachments', json={
            'item_id': 'item3',
            'attachment': {'key': 'value'}
        })
        response = self.app.put('/attachments/item3', json={
            'attachment': {'key': 'new_value'}
        })
        self.assertEqual(response.status_code, 200)
        self.assertIn('Attachment updated', response.get_data(as_text=True))

    def test_get_nonexistent_attachment(self):
        response = self.app.get('/attachments/nonexistent')
        self.assertEqual(response.status_code, 404)
        self.assertIn('Attachment not found', response.get_data(as_text=True))

if __name__ == '__main__':
    unittest.main()
