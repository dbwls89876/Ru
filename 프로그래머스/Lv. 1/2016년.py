import datetime

def solution(a, b):
    answer = ''
    day = (datetime.datetime(2016, a, b)).weekday()
    today = {0 : "MON", 1 : "TUE", 2 : "WED", 3 : "THU",4 : "FRI", 5 : "SAT", 6 : "SUN"}.get(day, "")

    answer = today
    
    return answer
