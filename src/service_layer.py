from src.api_client import APIClient
from src.models import SkuSeller

class SkuSellerService:
    def __init__(self, api_client):
        self.api_client = api_client

    def get_sku_seller(self, sku_id, seller_id):
        try:
            data = self.api_client.get_sku_seller(sku_id, seller_id)
            return SkuSeller.from_json(data)
        except Exception as e:
            print(f"Error retrieving SKU Seller: {e}")
            return None

    def delete_sku_seller(self, sku_id, seller_id):
        try:
            status_code = self.api_client.delete_sku_seller(sku_id, seller_id)
            return status_code == 204
        except Exception as e:
            print(f"Error deleting SKU Seller: {e}")
            return False

# Example usage:
# api_client = APIClient(base_url="https://api.vtex.com", headers={"Authorization": "Bearer token"})
# service = SkuSellerService(api_client)
# sku_seller = service.get_sku_seller("sku123", "seller456")
# success = service.delete_sku_seller("sku123", "seller456")
