import pyodbc, sys, statistics
import matplotlib.pyplot as plt
from datetime import datetime

# ==================================================

idSelectedSemiFinished = int(sys.argv[1])
dateFromProcess = datetime.strptime(sys.argv[2], '%d.%m.%Y %H:%M:%S')
dateFrom = datetime(dateFromProcess.year, dateFromProcess.month, dateFromProcess.day)
dateToProcess = datetime.strptime(sys.argv[3], '%d.%m.%Y %H:%M:%S')
dateTo = datetime(dateToProcess.year, dateToProcess.month, dateToProcess.day)
thickness = 0
width = 0
weight = 0
realThickness = []
realWidth = []
realWeight = []

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
Thickness, Width, SfWeight 
from
SemiFinished
where
idSemiFinished = {}'''.format(idSelectedSemiFinished)
    row = crsr.execute(sql).fetchone()
    thickness = row.Thickness
    width = row.Width
    weight = row.SfWeight

# ==================================================

with cnxn.cursor() as crsr:
    sql = '''select
EntranceControl.RealThickness, EntranceControl.RealWidth, EntranceControl.RealWeight 
from
EntranceControl
join SfOrderDetail
on EntranceControl.IdSfDetail = SfOrderDetail.IdSfDetail
join SemiFinished
on SfOrderDetail.IdSemiFinished = SemiFinished.IdSemiFinished
where 
SemiFinished.IdSemiFinished = {}
and EntranceControl.ControlDate between '{}' and '{}';'''.format(idSelectedSemiFinished, dateFrom, dateTo)
    crsr.execute(sql)
    while True:
        row = crsr.fetchone()
        if not row:
            break
        
        realThickness.append(float(row.RealThickness))
        realWidth.append(float(row.RealWidth))
        realWeight.append(float(row.RealWeight))

# ==================================================

cnxn.close()

# ==================================================

fig, hists = plt.subplots(1, 3, figsize=(12, 6), dpi = 70)
# hists[0] - thickness
# hists[1] - width
# hists[2] - weight

# ==================================================

nT, binsT, patchesT = hists[0].hist(realThickness, bins='auto', rwidth=0.1)

hists[0].vlines(statistics.mean(realThickness), 0, nT.max(), colors ='r')
hists[0].vlines([thickness, thickness * 0.95, thickness * 1.05], 0, nT.max())
hists[0].set_ylabel('Ilość wystąpień')
hists[0].set_title('Grubość')

# ==================================================

nW, binxW, patchesW = hists[1].hist(realWidth, bins='auto', rwidth=0.1)
hists[1].vlines(statistics.mean(realWidth), 0, nW.max(), colors ='r')
hists[1].vlines([width, width * 0.95, width * 1.05], 0, nW.max())
hists[1].set_title('Szerokość')

# ==================================================

nWe, binsWe, patchesWe = hists[2].hist(realWeight, bins='auto', rwidth=0.1)
hists[2].vlines(statistics.mean(realWeight), 0, nWe.max(), colors ='r')
hists[2].vlines([weight, weight * 0.95, weight * 1.05], 0, nWe.max())
hists[2].set_title('Ciężar')

# ==================================================

for ax in hists.flat:
    ax.set(xlabel = 'Wartość')

# ==================================================

plt.show()