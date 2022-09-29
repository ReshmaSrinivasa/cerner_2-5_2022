-- cerner_2tothe5th_2022
-- Prints 15 fibonacci numbers from the sequence

fibonacci = 0 : 1 : zipWith (+) fibonacci (tail fibonacci)

main = print $ take 15 fibonacci