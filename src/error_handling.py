class APIError(Exception):
    def __init__(self, status_code, message="API request failed"):
        self.status_code = status_code
        self.message = message
        super().__init__(self.message)

    def __str__(self):
        return f"{self.message} (Status Code: {self.status_code})"

def handle_api_errors(response):
    if not response.ok:
        raise APIError(status_code=response.status_code, message=response.text)

# Example usage in APIClient:
# response = requests.get(url, headers=self.headers)
# handle_api_errors(response)
# return response.json()
#
# This function can be used in the APIClient methods to handle errors.
