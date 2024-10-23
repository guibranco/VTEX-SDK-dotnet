class SKUComplement:
    def __init__(self, parent_sku_id, complement_sku_id, attributes=None):
        self.parent_sku_id = parent_sku_id
        self.complement_sku_id = complement_sku_id
        self.attributes = attributes or {}

    def to_dict(self):
        return {
            "parent_sku_id": self.parent_sku_id,
            "complement_sku_id": self.complement_sku_id,
            "attributes": self.attributes
        }
