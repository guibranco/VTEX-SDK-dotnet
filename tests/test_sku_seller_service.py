import unittest
from unittest.mock import MagicMock
from src.service_layer import SkuSellerService
from src.models import SkuSeller

class TestSkuSellerService(unittest.TestCase):
    def setUp(self):
        self.mock_api_client = MagicMock()
        self.service = SkuSellerService(self.mock_api_client)

    def test_get_sku_seller(self):
        # Mock API response
        self.mock_api_client.get_sku_seller.return_value = {
            'skuId': 'sku123',
            'sellerId': 'seller456',
            'price': 100.0,
            'inventory': 50
        }

        sku_seller = self.service.get_sku_seller('sku123', 'seller456')
        self.assertIsInstance(sku_seller, SkuSeller)
        self.assertEqual(sku_seller.sku_id, 'sku123')
        self.assertEqual(sku_seller.seller_id, 'seller456')

    def test_delete_sku_seller(self):
        # Mock API response
        self.mock_api_client.delete_sku_seller.return_value = 204

        success = self.service.delete_sku_seller('sku123', 'seller456')
        self.assertTrue(success)

if __name__ == '__main__':
    unittest.main()
