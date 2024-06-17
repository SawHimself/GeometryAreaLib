# GeometryAreaLib
<p3> Вопрос №3: <p3>
<br>
Left Join выбирает все строки первой таблицы и затем присоединяет к ним строки правой таблицы. 
```sql
SELECT ProductName, CategoryName 
FROM Products LEFT JOIN  Categories
ON Categories.Id = Products.CategoriesId
```
