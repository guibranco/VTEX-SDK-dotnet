-- Create table to associate SKU Services with Attachments
CREATE TABLE sku_service_attachments (
    sku_service_id INT NOT NULL,
    attachment_id INT NOT NULL,
    PRIMARY KEY (sku_service_id, attachment_id),
    FOREIGN KEY (sku_service_id) REFERENCES sku_services(id),
    FOREIGN KEY (attachment_id) REFERENCES attachments(id)
);

-- Add any additional constraints or indexes as needed
