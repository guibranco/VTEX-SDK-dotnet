import unittest
from sku_service_attachment_service import SKUServiceAttachmentService

class TestSKUServiceAttachment(unittest.TestCase):
    def setUp(self):
        # Mock database connection
        self.db_connection = MockDBConnection()
        self.service = SKUServiceAttachmentService(self.db_connection)

    def test_associate_attachment(self):
        result = self.service.associate_attachment(1, 2)
        self.assertEqual(result, "Attachment associated successfully")
        self.assertIn((1, 2), self.db_connection.data)

    def test_disassociate_attachment(self):
        self.db_connection.data.add((1, 2))
        result = self.service.disassociate_attachment(1, 2)
        self.assertEqual(result, "Attachment disassociated successfully")
        self.assertNotIn((1, 2), self.db_connection.data)

class MockDBConnection:
    def __init__(self):
        self.data = set()

    def execute(self, query, params):
        if "INSERT" in query:
            self.data.add(params)
        elif "DELETE" in query:
            self.data.discard(params)

if __name__ == '__main__':
    unittest.main()
