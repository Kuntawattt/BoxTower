# ไฟล์เกม 
https://drive.google.com/file/d/1b2U63Z2jR20ymwzdts4A9W0VIHv-_fPW/view?usp=sharing
# Build 
https://drive.google.com/file/d/1RzMuiEmPVD2CwQApYtq_VzU1Ov2zs0eJ/view?usp=sharing
# ชื่อเกม
Drop Build Box(DBB)
# รายละเอียดเกมสั้น ๆ
เป็นเกมการต่อตึกให้สูงขึ้น โดยการที่จะมีชั้นของตึกอยู่ที่ข้างบนและขยับซ้ายขวาเมื่อทำการกดคลิกซ้ายจะทำการปล่อยตึกลงมาและนับตึกที่ยังต่อกันหรือบนฐานจะได้คะแนน ถ้าตึกล้มหรือหลุดออกจากฐานร่วงลงไปจะแพ้
# วิธีการเล่น
ชั้นของตึกอยู่ที่ข้างบนและขยับซ้ายขวาเมื่อทำการกดคลิกซ้ายจะทำการปล่อยตึกลงมาและนับตึกที่ยังต่อกันหรือบนฐานจะได้คะแนน ถ้าตึกล้มหรือหลุดออกจากฐานร่วงลงไปจะแพ้
# โครงสร้างระบบ Multiplayer ที่ใช้
Netcode forGameObjects
# ปัญหาที่พบ และวิธีการแก้้ไข
1.Netcode: ไม่มีหน้าหรือไม่มีสิ่งอำนวยความสะดวกบางอย่าง
การแก้ไข: สร้างสคริปต์ Network Manager HUB ขึ้นมาเองโดยใช้ UI กับการสร้างปุ่มกดแล้วฝังสคริปต์ลงไป
2.หน้า UI ที่ใช้ทดสอบและ UI ที่แสดงผลจริง ตำแหน่งต่างกันเกินไป
การแก้ไข: ใช้วิธีการจัดเรียงแทนที่การวางด้วยมือ
3.เมื่อตัวตึกต่อกันเป็นจำนวนมากและกล้องยังอยู่ที่เดิมทำให้ไม่เป็นตัวตึกค่างบน
การแก้ไข  สร้างสคริปต์การขยับแกน y  ชึ้นเมื่อทำการวางตึกไป 5 อัน 

![Capture](https://github.com/user-attachments/assets/4fabaff7-6ae3-49ac-bcb8-261cc7c65fee)
![Captu1re](https://github.com/user-attachments/assets/af110644-6da2-4913-b703-a785c76c0fee)
