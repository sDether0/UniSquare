SELECT p.[Name], c.[Name]
  FROM [Shop].[dbo].[Product] p
  left join ProductXCatergory pxc on p.Id = pxc.ProductId
  left join Category c on pxc.CategoryId = c.Id