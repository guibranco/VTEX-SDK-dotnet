import requests

class APIClient:
    def __init__(self, base_url, headers):
        self.base_url = base_url
        self.headers = headers

    def get_sku_seller(self, sku_id, seller_id):
        url = f"{self.base_url}/sku/{sku_id}/seller/{seller_id}"
        response = requests.get(url, headers=self.headers)
        response.raise_for_status()
        return response.json()

    def delete_sku_seller(self, sku_id, seller_id):
        url = f"{self.base_url}/sku/{sku_id}/seller/{seller_id}"
        response = requests.delete(url, headers=self.headers)
        response.raise_for_status()
        return response.status_code

# Example usage:
# client = APIClient(base_url="https://api.vtex.com", headers={"Authorization": "Bearer token"})
