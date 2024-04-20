-- Tạo bảng Khoa
CREATE DATABASE TruongEF_DBFirst
GO
USE TruongEF_DBFirst
GO
CREATE TABLE Khoa (
    KhoaID INT PRIMARY KEY,
    TenKhoa NVARCHAR(100)
);

-- Tạo bảng Lop
CREATE TABLE Lop (
    LopID INT PRIMARY KEY,
    TenLop NVARCHAR(100),
    KhoaID INT,
    FOREIGN KEY (KhoaID) REFERENCES Khoa(KhoaID)
);

-- Tạo bảng SinhVien
CREATE TABLE SinhVien (
    SinhVienID INT PRIMARY KEY,
    TenSinhVien NVARCHAR(100),
    Tuoi INT,
    LopID INT,
    FOREIGN KEY (LopID) REFERENCES Lop(LopID)
);
