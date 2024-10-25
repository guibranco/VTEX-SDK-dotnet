class SkuSeller:
    def __init__(self, sku_id, seller_id, price, inventory):
        self.sku_id = sku_id
        self.seller_id = seller_id
        self.price = price
        self.inventory = inventory

    @classmethod
    def from_json(cls, data):
        return cls(
            sku_id=data.get('skuId'),
            seller_id=data.get('sellerId'),
            price=data.get('price'),
            inventory=data.get('inventory')
        )
