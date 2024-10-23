import unittest
from unittest.mock import patch, MagicMock
from services.SKUComplementService import SKUComplementService

class TestSKUComplementService(unittest.TestCase):
    def setUp(self):
        self.service = SKUComplementService()

    @patch('VTEX.VTEXWrapper.VTEXWrapper.GetSKUComplementAsync')
    def test_get_sku_complement(self, mock_get):
        mock_get.return_value = {'parent_sku_id': '123', 'complement_sku_id': '456'}
        result = self.service.get_sku_complement('1')
        self.assertEqual(result['parent_sku_id'], '123')
        self.assertEqual(result['complement_sku_id'], '456')

    @patch('VTEX.VTEXWrapper.VTEXWrapper.CreateSKUComplementAsync')
    def test_create_sku_complement(self, mock_create):
        self.service.create_sku_complement('123', '456')
        mock_create.assert_called_once()

    @patch('VTEX.VTEXWrapper.VTEXWrapper.UpdateSKUComplementAsync')
    def test_update_sku_complement(self, mock_update):
        self.service.update_sku_complement('1', '123', '456')
        mock_update.assert_called_once()

if __name__ == '__main__':
    unittest.main()
