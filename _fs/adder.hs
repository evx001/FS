add a b = a + b 
-- add 4 5  

add' a b c = a + b + c -- add' (add 3 4) 5 6  

add'' a b c d = a + b + c + d 

add003composed = sum [add 1 2, add' 3 4 5, add'' 6 7 8 9]
-- *Main> add003composed 
-- 45

