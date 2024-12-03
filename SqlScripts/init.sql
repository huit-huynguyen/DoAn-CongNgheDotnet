CREATE DATABASE CuaHangXe;
GO
USE CuaHangXe;
GO

-- ==============================================
-- TABLEs
-- ==============================================

CREATE TABLE nha_cung_cap (
    ma_ncc        CHAR(10)     PRIMARY KEY
  , ten_ncc       NVARCHAR(50) NOT NULL
  , dia_chi       NVARCHAR(70) NOT NULL
  , dia_chi_email NVARCHAR(30) NOT NULL
                               CHECK (dia_chi_email LIKE '%_@_%._%')
  , so_dien_thoai CHAR(10)     NOT NULL
                               CHECK (so_dien_thoai NOT LIKE '%[^0-9]%')
);
GO

CREATE TABLE xe (
    ma_xe         CHAR(10)       PRIMARY KEY
  , ten_xe        NVARCHAR(50)   NOT NULL
  , mo_ta         NVARCHAR(100)  NULL
  , hang_san_xuat NVARCHAR(50)   NOT NULL
  , bien_so_xe    CHAR(10)       NOT NULL
  , don_gia       DECIMAL(19, 4) NOT NULL DEFAULT (0)
                                 CHECK (don_gia >= 0)
  , so_luong      INT            NOT NULL DEFAULT (0)
                                 CHECK (so_luong >= 0)
  , ma_ncc        CHAR(10)       NOT NULL
                                 FOREIGN KEY REFERENCES nha_cung_cap (ma_ncc)
  , file_hinh_anh NVARCHAR(100)  NULL
);
GO

CREATE TABLE linh_kien (
    ma_lk         CHAR(10)       PRIMARY KEY
  , ten_lk        NVARCHAR(50)   NOT NULL
  , mo_ta         NVARCHAR(100)  NULL
  , don_gia       DECIMAL(19, 4) NOT NULL DEFAULT (0)
                                 CHECK (don_gia >= 0)
  , so_luong      INT            NOT NULL DEFAULT (0)
                                 CHECK (so_luong >= 0)
  , ma_ncc        CHAR(10)       NOT NULL
                                 FOREIGN KEY REFERENCES nha_cung_cap (ma_ncc)
  , file_hinh_anh NVARCHAR(100)  NULL
);
GO

CREATE TABLE nhan_vien (
    ma_nv         CHAR(10)     PRIMARY KEY
  , ho_ten        NVARCHAR(50) NOT NULL
  , mat_khau      NVARCHAR(50) NOT NULL
  , chuc_vu       NVARCHAR(20) NOT NULL
                               CHECK (chuc_vu IN (N'Quản lý', N'Thu ngân', N'Thủ kho', N'Kỹ thuật'))
  , gioi_tinh     NVARCHAR(4)  NOT NULL
                               CHECK (gioi_tinh IN (N'Nam', N'Nữ', N'Khác'))
  , ngay_sinh     DATE         NOT NULL
  , dia_chi       NVARCHAR(70) NOT NULL
  , dia_chi_email NVARCHAR(30) NOT NULL
                               CHECK (dia_chi_email LIKE '%_@_%._%')
  , so_dien_thoai CHAR(10)     NOT NULL
                               CHECK (so_dien_thoai NOT LIKE '%[^0-9]%')
);
GO

CREATE TABLE khach_hang (
    ma_kh         CHAR(10)     PRIMARY KEY
  , ho_ten        NVARCHAR(50) NOT NULL
  , gioi_tinh     NVARCHAR(4)  NOT NULL
                               CHECK (gioi_tinh IN (N'Nam', N'Nữ', N'Khác'))
  , ngay_sinh     DATE         NOT NULL
  , dia_chi       NVARCHAR(70) NOT NULL
  , dia_chi_email NVARCHAR(30) NOT NULL
                               CHECK (dia_chi_email LIKE '%_@_%._%')
  , so_dien_thoai CHAR(10)     NOT NULL
                               CHECK (so_dien_thoai NOT LIKE '%[^0-9]%')
);
GO

CREATE TABLE don_hang (
    ma_dh      CHAR(10)       PRIMARY KEY
  , ma_nv      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES nhan_vien (ma_nv)
  , ma_kh      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES khach_hang (ma_kh)
  , ngay_lap   DATE           NOT NULL DEFAULT (GETDATE())
                              CHECK (ngay_lap <= GETDATE())
  , tinh_trang NVARCHAR(20)   NOT NULL
                              CHECK (tinh_trang IN (N'Hoàn thành', N'Đã hủy', N'Chờ xử lý', N'Đang xử lý'))
  , tong_tien  DECIMAL(19, 4) NOT NULL DEFAULT (0)
                              CHECK (tong_tien >= 0)
);
GO

CREATE TABLE chi_tiet_don_hang (
    ma_ctdh    CHAR(10)       PRIMARY KEY
  , ma_dh      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES don_hang (ma_dh)
  , ma_xe      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES xe (ma_xe)
  , gia_ban    DECIMAL(19, 4) NOT NULL
                              CHECK (gia_ban >= 0)
  , so_luong   INT            NOT NULL
                              CHECK (so_luong >= 0)
  , thanh_tien DECIMAL(19, 4) NOT NULL DEFAULT(0)
                              CHECK (thanh_tien >= 0)
);
GO

CREATE TABLE phieu_sua (
    ma_ps      CHAR(10)       PRIMARY KEY
  , ma_nv      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES nhan_vien (ma_nv)
  , ma_kh      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES khach_hang (ma_kh)
  , ma_xe      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES xe (ma_xe)
  , ngay_lap   DATE           NOT NULL DEFAULT (GETDATE())
                              CHECK (ngay_lap <= GETDATE())
  , ngay_tra   DATE           NULL
  , mo_ta_loi  NVARCHAR(500)  NOT NULL
  , tinh_trang NVARCHAR(20)   NOT NULL
                              CHECK (tinh_trang IN (N'Hoàn thành', N'Đã hủy', N'Chờ sửa chữa', N'Đang sửa chữa'))
  , tong_tien  DECIMAL(19, 4) NOT NULL DEFAULT (0)
                              CHECK (tong_tien >= 0)
);
GO

CREATE TABLE chi_tiet_sua_chua (
    ma_ctsc    CHAR(10)       PRIMARY KEY
  , ma_ps      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES phieu_sua (ma_ps)
  , ma_lk      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES linh_kien (ma_lk)
  , ghi_chu    NVARCHAR(500)  NULL
  , gia_sua    DECIMAL(19, 4) NOT NULL
                              CHECK (gia_sua >= 0)
  , so_luong   INT            NOT NULL
                              CHECK (so_luong >= 0)
  , thanh_tien DECIMAL(19, 4) NOT NULL DEFAULT(0)
                              CHECK (thanh_tien >= 0)
);
GO

CREATE TABLE phieu_nhap (
    ma_pn     CHAR(10)       PRIMARY KEY
  , ma_nv     CHAR(10)       NOT NULL
                             FOREIGN KEY REFERENCES nhan_vien (ma_nv)
  , ma_ncc    CHAR(10)       NOT NULL
                             FOREIGN KEY REFERENCES nha_cung_cap (ma_ncc)
  , ngay_lap  DATE           NOT NULL DEFAULT (GETDATE())
                             CHECK (ngay_lap <= GETDATE())
  , tong_tien DECIMAL(19, 4) NOT NULL DEFAULT (0)
                             CHECK (tong_tien >= 0)
);
GO

CREATE TABLE chi_tiet_nhap_hang (
    ma_ctnh    CHAR(10)       PRIMARY KEY
  , ma_pn      CHAR(10)       NOT NULL
                              FOREIGN KEY REFERENCES phieu_nhap (ma_pn)
  , ma_xe      CHAR(10)       NULL
                              FOREIGN KEY REFERENCES xe (ma_xe)
  , ma_lk      CHAR(10)       NULL
                              FOREIGN KEY REFERENCES linh_kien (ma_lk)
  , gia_nhap   DECIMAL(19, 4) NOT NULL
                              CHECK (gia_nhap >= 0)
  , so_luong   INT            NOT NULL
                              CHECK (so_luong >= 0)
  , thanh_tien DECIMAL(19, 4) NOT NULL DEFAULT(0)
                              CHECK (thanh_tien >= 0)
);
GO

-- ==============================================
-- TRIGGERs
-- ==============================================

-- Kiểm tra ngày lập và ngày trả của phiếu sửa.
CREATE TRIGGER trg_kiem_tra_ngay_lap_tra_phieu_sua
ON phieu_sua
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
          FROM inserted
         WHERE ngay_lap > GETDATE()
               OR (ngay_tra IS NOT NULL AND ngay_tra < ngay_lap)
    )
    BEGIN
        RAISERROR(N'Ngày lập không thể trong tương lai và ngày trả phải sau ngày lập', 16, 1)
        ROLLBACK TRANSACTION
    END
END;
GO

-- Đảm bảo trong phiếu nhập, chi tiết nhập hàng chỉ chứa xe hoặc linh kiện.
-- Không thể chứa cả xe và linh kiện trong cùng một chi tiết.
CREATE TRIGGER trg_kiem_tra_loai_hang_chi_tiet_nhap
ON chi_tiet_nhap_hang
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
        SELECT 1
          FROM inserted
         WHERE ma_xe IS NOT NULL
               AND ma_lk IS NOT NULL
    )
    BEGIN
        RAISERROR(N'Chi tiết nhập hàng chỉ chứa xe hoặc linh kiện', 16, 1)
        ROLLBACK TRANSACTION
    END
END;
GO

-- Đảm bảo nhà cung cấp giống nhau cho tất cả chi tiết nhập hàng.
CREATE TRIGGER trg_kiem_tra_nha_cung_cap_phieu_nhap
ON chi_tiet_nhap_hang
FOR INSERT, UPDATE
AS
BEGIN
    IF EXISTS (
           SELECT 1
             FROM inserted AS i
             JOIN phieu_nhap AS pn
               ON i.ma_pn = pn.ma_pn
        LEFT JOIN xe AS x
               ON i.ma_xe = x.ma_xe
        LEFT JOIN linh_kien AS lk
               ON i.ma_lk = lk.ma_lk
            WHERE (x.ma_ncc != pn.ma_ncc AND i.ma_xe IS NOT NULL)
                  OR (lk.ma_ncc != pn.ma_ncc AND i.ma_lk IS NOT NULL)
    )
    BEGIN
        RAISERROR(N'Nhà cung cấp của hàng nhập phải giống với nhà cung cấp trong phiếu nhập', 16, 1)
        ROLLBACK TRANSACTION
    END
END;
GO

-- Tự động tính thành tiền khi thêm hoặc sửa chi tiết đơn hàng.
-- Thành tiền = số lượng × giá bán
CREATE TRIGGER trg_tinh_thanh_tien_don_hang
ON chi_tiet_don_hang
FOR INSERT, UPDATE
AS
BEGIN
    UPDATE ctdh
       SET thanh_tien = i.so_luong * i.gia_ban
      FROM chi_tiet_don_hang AS ctdh
      JOIN inserted AS i
        ON ctdh.ma_ctdh = i.ma_ctdh
END;
GO

-- Tự động cập nhật tổng tiền đơn hàng khi thêm, sửa hoặc xóa chi tiết đơn hàng.
-- Tổng tiền = tổng các thành tiền của tất cả chi tiết
CREATE TRIGGER trg_cap_nhat_tong_tien_don_hang
ON chi_tiet_don_hang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE dh
       SET tong_tien = (
           SELECT COALESCE(SUM(thanh_tien), 0)
             FROM chi_tiet_don_hang AS ctdh
            WHERE ctdh.ma_dh = dh.ma_dh
       )
      FROM don_hang AS dh
      JOIN (
          SELECT ma_dh
            FROM inserted
           UNION
          SELECT ma_dh
            FROM deleted
      ) AS t
        ON dh.ma_dh = t.ma_dh
END;
GO

-- Tự động cập nhật số lượng xe trong kho khi bán.
CREATE TRIGGER trg_cap_nhat_so_luong_xe_ban
ON chi_tiet_don_hang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
       UPDATE x
          SET so_luong = x.so_luong
                         - COALESCE(i.so_luong, 0)
                         + COALESCE(d.so_luong, 0)
         FROM xe AS x
    LEFT JOIN inserted AS i
           ON x.ma_xe = i.ma_xe
    LEFT JOIN deleted AS d
           ON x.ma_xe = d.ma_xe
        WHERE i.ma_xe IS NOT NULL
              OR d.ma_xe IS NOT NULL
END;
GO

-- Tự động tính thành tiền khi thêm hoặc sửa chi tiết sửa chữa.
-- Thành tiền = số lượng × giá sửa
CREATE TRIGGER trg_tinh_thanh_tien_sua_chua
ON chi_tiet_sua_chua
FOR INSERT, UPDATE
AS
BEGIN
    UPDATE ctsc
       SET thanh_tien = i.so_luong * i.gia_sua
      FROM chi_tiet_sua_chua AS ctsc
      JOIN inserted AS i
        ON ctsc.ma_ctsc = i.ma_ctsc
END;
GO

-- Tự động cập nhật tổng tiền phiếu sửa khi thêm, sửa hoặc xóa chi tiết.
-- Tổng tiền = tổng các thành tiền của tất cả chi tiết
CREATE TRIGGER trg_cap_nhat_tong_tien_phieu_sua
ON chi_tiet_sua_chua
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE ps
       SET tong_tien = (
           SELECT COALESCE(SUM(thanh_tien), 0)
             FROM chi_tiet_sua_chua AS ctsc
            WHERE ctsc.ma_ps = ps.ma_ps
       )
      FROM phieu_sua AS ps
      JOIN (
          SELECT ma_ps
            FROM inserted
           UNION
          SELECT ma_ps
            FROM deleted
      ) AS t
        ON ps.ma_ps = t.ma_ps
END;
GO

-- Tự động cập nhật số lượng linh kiện trong kho khi sửa chữa.
CREATE TRIGGER trg_cap_nhat_so_luong_linh_kien_sua
ON chi_tiet_sua_chua
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
       UPDATE lk
          SET so_luong = lk.so_luong
                         - COALESCE(i.so_luong, 0)
                         + COALESCE(d.so_luong, 0)
         FROM linh_kien AS lk
    LEFT JOIN inserted AS i
           ON lk.ma_lk = i.ma_lk
    LEFT JOIN deleted AS d
           ON lk.ma_lk = d.ma_lk
        WHERE i.ma_lk IS NOT NULL
              OR d.ma_lk IS NOT NULL
END;
GO

-- Tự động tính thành tiền khi thêm hoặc sửa chi tiết nhập hàng.
-- Thành tiền = số lượng × giá nhập
CREATE TRIGGER trg_tinh_thanh_tien_nhap_hang
ON chi_tiet_nhap_hang
FOR INSERT, UPDATE
AS
BEGIN
    UPDATE ctnh
       SET thanh_tien = i.so_luong * i.gia_nhap
      FROM chi_tiet_nhap_hang AS ctnh
      JOIN inserted AS i
        ON ctnh.ma_ctnh = i.ma_ctnh
END;
GO

-- Tự động cập nhật tổng tiền phiếu nhập khi thêm, sửa hoặc xóa chi tiết.
-- Tổng tiền = tổng các thành tiền của tất cả chi tiết
CREATE TRIGGER trg_cap_nhat_tong_tien_phieu_nhap
ON chi_tiet_nhap_hang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    UPDATE pn
       SET tong_tien = (
           SELECT COALESCE(SUM(thanh_tien), 0)
             FROM chi_tiet_nhap_hang AS ctnh
            WHERE ctnh.ma_pn = pn.ma_pn
       )
      FROM phieu_nhap AS pn
      JOIN (
          SELECT ma_pn
            FROM inserted
           UNION
          SELECT ma_pn
            FROM deleted
      ) AS t
        ON pn.ma_pn = t.ma_pn
END;
GO

-- Tự động cập nhật số lượng xe/linh kiện trong kho khi nhập hàng.
CREATE TRIGGER trg_cap_nhat_so_luong_hang_nhap
ON chi_tiet_nhap_hang
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
       UPDATE x
          SET so_luong = x.so_luong
                         + COALESCE(i.so_luong, 0)
                         - COALESCE(d.so_luong, 0)
         FROM xe AS x
    LEFT JOIN inserted AS i
           ON x.ma_xe = i.ma_xe
    LEFT JOIN deleted AS d
           ON x.ma_xe = d.ma_xe
        WHERE i.ma_xe IS NOT NULL
              OR d.ma_xe IS NOT NULL

       UPDATE lk
          SET so_luong = lk.so_luong
                         + COALESCE(i.so_luong, 0)
                         - COALESCE(d.so_luong, 0)
         FROM linh_kien AS lk
    LEFT JOIN inserted AS i
           ON lk.ma_lk = i.ma_lk
    LEFT JOIN deleted AS d
           ON lk.ma_lk = d.ma_lk
        WHERE i.ma_lk IS NOT NULL
              OR d.ma_lk IS NOT NULL
END;
GO

-- ==============================================
-- Nhập dữ liệu mẫu
-- ==============================================

INSERT INTO nha_cung_cap (ma_ncc, ten_ncc, dia_chi, dia_chi_email, so_dien_thoai)
VALUES
('NCC001', N'Yamaha Motor Việt Nam', N'KCN Quang Minh, Mê Linh, Hà Nội',                 N'yamaha@example.com',  '0123456789'),
('NCC002', N'Honda Việt Nam',        N'KCN Phúc Thắng, Phúc Thắng, Phúc Yên, Vĩnh Phúc', N'honda@example.com',   '0987654321'),
('NCC003', N'Suzuki Việt Nam',       N'KCN Thăng Long, Đông Anh, Hà Nội',                N'suzuki@example.com',  '0369852147'),
('NCC004', N'Piaggio Việt Nam',      N'KCN Đồng Văn, Duy Tiên, Hà Nam',                  N'piaggio@example.com', '0123456789'),
('NCC005', N'VinFast',               N'KCN Đình Vũ, Hải An, Hải Phòng',                  N'vinfast@example.com', '0987654321');
GO

INSERT INTO xe (ma_xe, ten_xe, mo_ta, hang_san_xuat, bien_so_xe, don_gia, so_luong, ma_ncc, file_hinh_anh)
VALUES
('XE001', N'Exciter 150', N'Xe côn tay thể thao', N'Yamaha',  '29A-12345', 45000000, 10, 'NCC001', 'exciter_150.png'),
('XE002', N'Winner X',    N'Xe côn tay thể thao', N'Honda',   '29A-54321', 40000000, 15, 'NCC002', 'winner_x.png'),
('XE003', N'Raider 150',  N'Xe côn tay thể thao', N'Suzuki',  '29A-67890', 42000000, 20, 'NCC003', 'raider_150.png'),
('XE004', N'Liberty',     N'Xe ga phong cách',    N'Piaggio', '29A-09876', 35000000, 25, 'NCC004', 'liberty.png'),
('XE005', N'Lux A2.0',    N'Ô tô điện',           N'VinFast', '29A-56789', 80000000, 30, 'NCC005', 'lux_a2.0.png'),
('XE006', N'Fadil',       N'Ô tô điện',           N'VinFast', '29A-45678', 70000000, 35, 'NCC005', 'fadil.png'),
('XE007', N'Klara',       N'Xe máy điện',         N'VinFast', '29A-23456', 30000000, 40, 'NCC005', 'klara.png'),
('XE008', N'Impes',       N'Xe máy điện',         N'VinFast', '29A-34567', 25000000, 45, 'NCC005', 'impes.png'),
('XE009', N'Sirius FI',   N'Xe số',               N'Yamaha',  '29A-34567', 15000000, 50, 'NCC001', 'sirius_fi.png'),
('XE010', N'Wave Alpha',  N'Xe số',               N'Honda',   '29A-45678', 16000000, 55, 'NCC002', 'wave_alpha.png'),
('XE011', N'Hayate',      N'Xe số',               N'Suzuki',  '29A-56789', 17000000, 60, 'NCC003', 'hayate.png'),
('XE012', N'Liberty S',   N'Xe ga phong cách',    N'Piaggio', '29A-67890', 18000000, 65, 'NCC004', 'liberty_s.png');
GO

INSERT INTO linh_kien (ma_lk, ten_lk, mo_ta, don_gia, so_luong, ma_ncc, file_hinh_anh)
VALUES
('LK001', N'Bình ắc quy', N'Bình ắc quy xe máy',  500000, 100, 'NCC001', 'binh_ac_quy.png'),
('LK002', N'Lốp xe',      N'Lốp xe máy',          300000, 200, 'NCC002', 'lop_xe.png'),
('LK003', N'Đèn pha',     N'Đèn pha xe máy',      200000, 150, 'NCC003', 'den_pha.png'),
('LK004', N'Gương xe',    N'Gương xe máy',        100000, 250, 'NCC004', 'guong_xe.png'),
('LK005', N'Phanh xe',    N'Phanh xe máy',        400000, 120, 'NCC005', 'phanh_xe.png');
GO

INSERT INTO nhan_vien (ma_nv, ho_ten, mat_khau, chuc_vu, gioi_tinh, ngay_sinh, dia_chi, dia_chi_email, so_dien_thoai)
VALUES
('NV001', N'Nguyễn Văn A', '123456', N'Quản lý',  N'Nam', '1990-01-01', N'Hà Nội', 'nv1@example.com', '0123456789'),
('NV002', N'Nguyễn Thị B', '123456', N'Thu ngân', N'Nữ',  '1995-02-02', N'Hà Nội', 'nv2@example.com', '0987654321'),
('NV003', N'Trần Văn C',   '123456', N'Thủ kho',  N'Nam', '1993-03-03', N'Hà Nội', 'nv3@example.com', '0369852147'),
('NV004', N'Lê Thị D',     '123456', N'Kỹ thuật', N'Nữ',  '1992-04-04', N'Hà Nội', 'nv4@example.com', '0123456789'),
('NV005', N'Phạm Văn E',   '123456', N'Kỹ thuật', N'Nam', '1991-05-05', N'Hà Nội', 'nv5@example.com', '0987654321');
GO

INSERT INTO khach_hang (ma_kh, ho_ten, gioi_tinh, ngay_sinh, dia_chi, dia_chi_email, so_dien_thoai)
VALUES
('KH001', N'Nguyễn Văn F', N'Nam', '1990-01-01', N'Hồ Chí Minh', 'kh1@example.com', '0123456789'),
('KH002', N'Nguyễn Thị G', N'Nữ',  '1995-02-02', N'Hà Nội',      'kh2@example.com', '0987654321'),
('KH003', N'Trần Văn H',   N'Nam', '1993-03-03', N'Đà Nẵng',     'kh3@example.com', '0369852147'),
('KH004', N'Lê Thị I',     N'Nữ',  '1992-04-04', N'Hải Phòng',   'kh4@example.com', '0123456789'),
('KH005', N'Phạm Văn J',   N'Nam', '1991-05-05', N'Cần Thơ',     'kh5@example.com', '0987654321');
GO

INSERT INTO don_hang (ma_dh, ma_nv, ma_kh, ngay_lap, tinh_trang)
VALUES
('DH001', 'NV002', 'KH001', '2024-01-01', N'Hoàn thành'),
('DH002', 'NV002', 'KH002', '2024-02-02', N'Hoàn thành'),
('DH003', 'NV002', 'KH003', '2024-03-03', N'Hoàn thành'),
('DH004', 'NV002', 'KH004', '2024-04-04', N'Đang xử lý'),
('DH005', 'NV002', 'KH005', '2024-05-05', N'Chờ xử lý');
GO

INSERT INTO chi_tiet_don_hang (ma_ctdh, ma_dh, ma_xe, gia_ban, so_luong)
VALUES
('CTDH001', 'DH001', 'XE001', 45000000, 1),
('CTDH002', 'DH002', 'XE002', 40000000, 1),
('CTDH003', 'DH003', 'XE003', 42000000, 1),
('CTDH004', 'DH004', 'XE004', 35000000, 1),
('CTDH005', 'DH005', 'XE005', 80000000, 1);
GO

INSERT INTO phieu_sua (ma_ps, ma_nv, ma_kh, ma_xe, ngay_lap, mo_ta_loi, tinh_trang)
VALUES
('PS001', 'NV004', 'KH001', 'XE010', '2024-11-01', N'Xe không khởi động', N'Hoàn thành'),
('PS002', 'NV004', 'KH002', 'XE007', '2024-07-02', N'Xe không chạy',      N'Hoàn thành'),
('PS003', 'NV004', 'KH003', 'XE012', '2024-05-03', N'Xe không phanh',     N'Hoàn thành'),
('PS004', 'NV004', 'KH004', 'XE004', '2024-04-04', N'Xe không đèn',       N'Đang sửa chữa'),
('PS005', 'NV004', 'KH005', 'XE006', '2024-05-05', N'Xe không chạy',      N'Chờ sửa chữa');
GO

INSERT INTO chi_tiet_sua_chua (ma_ctsc, ma_ps, ma_lk, ghi_chu, gia_sua, so_luong)
VALUES
('CTSC001', 'PS001', 'LK001', N'Đã thay mới', 500000, 1),
('CTSC002', 'PS002', 'LK002', N'Đã thay mới', 300000, 1),
('CTSC003', 'PS003', 'LK003', N'Đã thay mới', 200000, 1),
('CTSC004', 'PS004', 'LK004', N'Đã thay mới', 100000, 1),
('CTSC005', 'PS005', 'LK005', N'Đã thay mới', 400000, 1);
GO

INSERT INTO phieu_nhap (ma_pn, ma_nv, ma_ncc, ngay_lap)
VALUES
('PN001', 'NV003', 'NCC001', '2024-06-01'),
('PN002', 'NV003', 'NCC002', '2024-04-12'),
('PN003', 'NV003', 'NCC003', '2024-08-23'),
('PN004', 'NV003', 'NCC004', '2024-01-30'),
('PN005', 'NV003', 'NCC005', '2024-07-05');
GO

INSERT INTO chi_tiet_nhap_hang (ma_ctnh, ma_pn, ma_xe, gia_nhap, so_luong)
VALUES
('CTNH001', 'PN001', 'XE009', 15000000, 10),
('CTNH002', 'PN002', 'XE010', 16000000, 15),
('CTNH003', 'PN003', 'XE011', 17000000, 20),
('CTNH004', 'PN004', 'XE012', 18000000, 25),
('CTNH005', 'PN005', 'XE005', 80000000, 30);
GO
