class Authentication:
    def __init__(self, token):
        self.token = token

    def get_headers(self):
        return {
            "Authorization": f"Bearer {self.token}",
            "Content-Type": "application/json"
        }

# Example usage:
# auth = Authentication(token="your_api_token")
# headers = auth.get_headers()
# api_client = APIClient(base_url="https://api.vtex.com", headers=headers)
# service = SkuSellerService(api_client)
# sku_seller = service.get_sku_seller("sku123", "seller456")
