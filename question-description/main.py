# First Part
def minNumDay(SamDaily, KellyDaily, Difference):
    if SamDaily >= KellyDaily:
        return -1 
    days = 0
    
    while Difference > -1:
        SamSolved = Difference + SamDaily
        KellySolved = KellyDaily
        Difference = SamSolved - KellySolved
        days += 1
    return days

# Example for the first part 
SamDaily = 3
KellyDaily = 5
Difference = 1
result = minNumDay(SamDaily, KellyDaily, Difference)
print(result)  


# Second Part