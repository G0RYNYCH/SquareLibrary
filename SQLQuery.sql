SELECT p.Name as ProductName, c.Name as CategoryName 
FROM Products p
LEFT JOIN ProductsCategories pc 
	ON p.Id = pc.ProductId
LEFT JOIN Categories c 
	ON pc.CategoryId = c.Id
	
