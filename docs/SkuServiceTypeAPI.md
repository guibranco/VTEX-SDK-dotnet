# SKU Service Type API Documentation

## Overview

The SKU Service Type API allows for the creation, updating, and deletion of SKU Service Types, providing flexibility and manageability for SKU behaviors.

## Endpoints

### Create SKU Service Type

**POST** `/api/SkuServiceType`

#### Request Body
```json
{
  "name": "string",
  "description": "string"
}
```

### Update SKU Service Type

**PUT** `/api/SkuServiceType/{id}`

#### Request Body
```json
{
  "name": "string",
  "description": "string"
}
```

### Delete SKU Service Type

**DELETE** `/api/SkuServiceType/{id}`

## Usage

Use the above endpoints to manage SKU Service Types effectively. Ensure to replace `{id}` with the actual SKU Service Type ID when updating or deleting.