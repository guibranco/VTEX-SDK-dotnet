from models.SKUComplement import SKUComplement
from VTEX.VTEXWrapper import VTEXWrapper

class SKUComplementService:
    def __init__(self):
        self.vtex_wrapper = VTEXWrapper()

    def get_sku_complement(self, complement_id):
        return self.vtex_wrapper.GetSKUComplementAsync(complement_id)

    def create_sku_complement(self, parent_sku_id, complement_sku_id, attributes=None):
        sku_complement = SKUComplement(parent_sku_id, complement_sku_id, attributes)
        self.vtex_wrapper.CreateSKUComplementAsync(sku_complement)

    def update_sku_complement(self, complement_id, parent_sku_id, complement_sku_id, attributes=None):
        sku_complement = SKUComplement(parent_sku_id, complement_sku_id, attributes)
        self.vtex_wrapper.UpdateSKUComplementAsync(complement_id, sku_complement)

    # Additional methods for error handling and response processing can be added here
