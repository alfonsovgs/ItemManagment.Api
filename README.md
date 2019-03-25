# ItemManagment.Api
Implementation of OData

Execute to:
  Get all: https://localhost:44330/api/items
  Get all, but only some properties: https://localhost:44330/api/items?$select=Name
  Get all, but only some properties: https://localhost:44330/api/items?$select=Name,Code
  Get all, some properties and order by https://localhost:44330/api/items?$select=Name,Code&$OrderBy=Name
  Get all, some properties, order by and filter https://localhost:44330/api/items?$select=Name,Code&$OrderBy=Name&$Filter=Id gt 10
