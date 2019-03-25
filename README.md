# ItemManagment.Api
Implementation of OData

**Execute to:**
  1. Get all: https://localhost:44330/api/items
  2. Get all, but only some properties: https://localhost:44330/api/items?$select=Name
  3. Get all, but only some properties: https://localhost:44330/api/items?$select=Name,Code
  4. Get all, some properties and order by https://localhost:44330/api/items?$select=Name,Code&$OrderBy=Name
  5. Get all, some properties, order by and filter https://localhost:44330/api/items?$select=Name,Code&$OrderBy=Name&$Filter=Id gt 10
