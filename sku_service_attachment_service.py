class SKUServiceAttachmentService:
    def __init__(self, db_connection):
        self.db = db_connection

    def associate_attachment(self, sku_service_id, attachment_id):
        # Logic to associate attachment
        query = "INSERT INTO sku_service_attachments (sku_service_id, attachment_id) VALUES (%s, %s)"
        self.db.execute(query, (sku_service_id, attachment_id))
        return "Attachment associated successfully"

    def disassociate_attachment(self, sku_service_id, attachment_id):
        # Logic to disassociate attachment
        query = "DELETE FROM sku_service_attachments WHERE sku_service_id = %s AND attachment_id = %s"
        self.db.execute(query, (sku_service_id, attachment_id))
        return "Attachment disassociated successfully"

# Example usage
# db_connection = get_db_connection()
# service = SKUServiceAttachmentService(db_connection)
# service.associate_attachment(1, 2)
# service.disassociate_attachment(1, 2)
