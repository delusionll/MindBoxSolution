Select Production.Product.Name, Production.Product.ProductCategory
From Production.Product Left Join Production.ProductCategory On Production.Product.ProductId = Production.ProductCategory.ProductId;