# TripPlannerAPI

## Overview
- .NET 9 Web API 
- DB: trip_planner (users, trips, user_trips)
- API: GET /api/trips?destination=Chiang&active=true&limit=5, POST /api/trips

# Debug  (ข้อ 2.4)

## ขั้นตอนการ Debug
1. ตั้ง Breakpoint ที่ `return Ok(trips);` TripsController.cs บรรทัด 33
2. Run Debug (F5)
3. เรียก API: `https://localhost:5001/api/trips?destination=Chiang&active=true&limit=2`

## Add Watch
- `trips.Count`
- `trips[0].trip_name`
- `trips[1].destination`

