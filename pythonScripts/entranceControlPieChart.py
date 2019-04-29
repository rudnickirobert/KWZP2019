import pyodbc, sys
import matplotlib.pyplot as plt
from datetime import datetime

# ==================================================

idSelectedSemiFinished = int(sys.argv[1])
dateFromProcess = datetime.strptime(sys.argv[2], '%d.%m.%Y %H:%M:%S')
dateFrom = datetime(dateFromProcess.year, dateFromProcess.month, dateFromProcess.day)
dateToProcess = datetime.strptime(sys.argv[3], '%d.%m.%Y %H:%M:%S')
dateTo = datetime(dateToProcess.year, dateToProcess.month, dateToProcess.day)
positiveControls = 0
negativeControls = 0

# ==================================================

cnxn = pyodbc.connect(
    "Driver={SQL Server};"
    r"Server=.\SQLEXPRESS;"
    "Database=RoofingCompany;"
    "Thrusted_Connection=yes;"
    )

# ==================================================

with cnxn.cursor() as crsr:
    sql = '''select 
count(*)
from
EntranceControl
join SfOrderDetail
on EntranceControl.IdSfDetail = SfOrderDetail.IdSfDetail
join SemiFinished
on SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
where SemiFinished.IdSemiFinished = {} and EntranceControl.ControlStatus = 1
and EntranceControl.ControlDate between '{}' and '{}';'''.format(idSelectedSemiFinished, dateFrom, dateTo)
    positiveControls = crsr.execute(sql).fetchval()

# ==================================================

with cnxn.cursor() as crsr:
    sql = '''select 
count(*)
from
EntranceControl
join SfOrderDetail
on EntranceControl.IdSfDetail = SfOrderDetail.IdSfDetail
join SemiFinished
on SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
where SemiFinished.IdSemiFinished = {} and EntranceControl.ControlStatus = 0
and EntranceControl.ControlDate between '{}' and '{}';'''.format(idSelectedSemiFinished, dateFrom, dateTo)
    negativeControls = crsr.execute(sql).fetchval()

# ==================================================

cnxn.close()

# ==================================================

plt.pie([positiveControls, negativeControls], labels=['Pozytywne', 'Negatywne'], colors=['g', 'r'], autopct='%.1f%%')
plt.axis('equal')
plt.show()