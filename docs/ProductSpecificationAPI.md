# Product Specification API

The Product Specification API allows you to manage additional information (specifications) of a product on the VTEX platform through our SDK.

## Features

- **Consult Specifications**: Retrieve detailed product specifications.
- **Create Specifications**: Add new specifications to a product.
- **Update Specifications**: Modify existing product specifications.

## Usage

### Get Product Specifications

```csharp
var specifications = await productSpecificationsService.GetProductSpecificationsAsync(productId);
```

### Create Product Specification

```csharp
await productSpecificationsService.CreateProductSpecificationAsync(newSpecification);
```

### Update Product Specification

```csharp
await productSpecificationsService.UpdateProductSpecificationAsync(existingSpecification);
```
