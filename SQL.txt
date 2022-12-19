SELECT DISTINCT
       pr.name AS name_product,
       c.name AS name_category
  FROM product pr
  LEFT JOIN 
       pairs pa
    ON pr.product_id = pa.product_id
  JOIN category c
    ON pa.category_id = c.category_id
 ORDER BY name_product