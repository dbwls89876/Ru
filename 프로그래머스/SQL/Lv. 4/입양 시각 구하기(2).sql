-- 코드를 입력하세요
# SELECT cte, COUNT(SUBSTRING(DATETIME, 12, 2)) FROM ANIMAL_OUTS
# GROUP BY SUBSTRING(DATETIME, 12, 2)

-- 0시부터 23시까지의 시간 테이블 생성
-- 입양 시간별로 구분되어있는 테이블 생성
WITH RECURSIVE TIME AS (
    SELECT 0 AS HOUR
    UNION ALL
    SELECT HOUR + 1 FROM TIME WHERE HOUR < 23
), ANIMAL_HOUR AS (
    SELECT SUBSTRING(DATETIME, 12, 2) AS HOUR, COUNT(SUBSTRING(DATETIME, 12, 2)) AS COUNT
                       FROM ANIMAL_OUTS
                       GROUP BY HOUR
)
SELECT TIME.HOUR, IFNULL(ANIMAL_HOUR.COUNT, 0) AS COUNT FROM ANIMAL_HOUR
RIGHT OUTER JOIN TIME ON TIME.HOUR = ANIMAL_HOUR.HOUR


-- 다른풀이, 해당 시간의 동물 수를 세는 방법(서브쿼리 사용 x)
  
SELECT TIME.HOUR, COUNT(ANIMAL.ANIMAL_ID) AS COUNT FROM ANIMAL_OUTS AS ANIMAL
RIGHT JOIN TIME ON TIME.HOUR = HOUR(ANIMAL.DATETIME)
GROUP BY TIME.HOUR
ORDER BY TIME.HOUR

-- 서브쿼리로 해결해볼려고 시도했으나 count값은 하나만 나오기때문에..
-- FROM 이후에 서브쿼리를 생성해 해결하는 방법도 가능
# select time.hour, COUNT(select SUBSTRING(DATETIME, 12, 2) AS hour
#                        FROM ANIMAL_OUTS
#                        GROUP BY hour) AS COUNT from time

-- 시간별 출력
# select SUBSTRING(DATETIME, 12, 2) AS hour
#                        FROM ANIMAL_OUTS
#                        GROUP BY hour
