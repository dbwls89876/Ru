
-- 성공
select COUNT(
  IF(
    (SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char), -1, 1) = 1 
    OR SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char), -3, 1) = 1) 
    AND SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char), -2, 1) = 0, 1, null)) AS COUNT 
  from ECOLI_DATA


-- char 가변길이 지정으로 인한 실패(테스트한다고 넣어넣고 수정안함), varchar은 conv 시 사용x
-- select COUNT(IF((SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char(4)), -1, 1) = 1 OR SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char(4)), -3, 1) = 1) AND SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char(4)), -2, 1) = 0, 1, null)) AS COUNT from ECOLI_DATA

-- select (CONVERT(CONV(GENOTYPE, 10, 2), char(5))) from ECOLI_DATA 코드화깅ㄴ

-- select CONVERT(CONV(GENOTYPE, 10, 2), char(5)) as data, SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char(5)), -1, 1) AS one, SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char(5)), -3, 1) as three, SUBSTRING(CONVERT(CONV(GENOTYPE, 10, 2), char(5)), -2, 1) AS two from ECOLI_DATA   문자열 별 값 데이터 확잉ㄴ

-- 정석적인 풀이 비트 연산자 계산 ㅠㅋㅋ 문제보자마자 비트연산자 수행하면 되겠네 했는데 MYSQL 에 비트연산자가 있을지 생각도 못한 바보가 되 어쩐지 레벨1이드라
SELECT   *
  FROM    ECOLI_DATA A
 WHERE  1=1
                AND (GENOTYPE & 2) != 2 
                 AND ((GENOTYPE & 4) = 4 OR (GENOTYPE & 1) = 1)
