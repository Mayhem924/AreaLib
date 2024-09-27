# Тестовое задание Mindbox

### SQL

```
SELECT ProductName, CategoryName
FROM Products 
LEFT JOIN ProductsCategories ON Products.ProductId = ProductsCategories.ProductId
LEFT JOIN Categories ON Categories.CategoryId = ProductsCategories.CategoryId
```