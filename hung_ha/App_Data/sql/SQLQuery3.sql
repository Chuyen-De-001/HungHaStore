ALTER TABLE tblUser
ADD email NVARCHAR(255) NOT NULL;

ALTER TABLE tblProduct
ADD CONSTRAINT PK_tblProduct PRIMARY KEY (id);

ALTER TABLE tblProduct ALTER COLUMN id int NOT NULL;

ALTER TABLE tblInfo ADD CONSTRAINT fk_user FOREIGN KEY (user_id) REFERENCES tblUsers (id);

ALTER TABLE tblInvoice ADD CONSTRAINT fk_user_1 FOREIGN KEY (user_id) REFERENCES tblUsers (id);


ALTER TABLE tblInvoiceDetail ADD CONSTRAINT fk_invoice FOREIGN KEY (user_id) REFERENCES tblInvoice (id);

ALTER TABLE tblProduct DROP COLUMN id;



ALTER TABLE tblProduct
   ADD ID INT IDENTITY
       CONSTRAINT PK_YourTable PRIMARY KEY CLUSTERED


insert into tblProductCategory(name,created_at) values (N'Giá sách',1634231321),(N'Kệ ti vi',1634231321),(N'Tủ quần áo',1634231321),(N'Bàn ghế ăn',1634231321),(N'Bàn làm việc',1634231321),(N'Giường',1634231321)

select * from tblProductCategory

select * from tblProduct


delete from tblProduct

insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ góc bằng gỗ MDF kết cấu chắc chắn GHS-2400',1,N'hiện tại chưa có mô tả về sản phẩm',1800000,1633862094,'ke-goc-bang-go-mdf-ket-cau-chac-chan-ghs-2400-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ để sách bằng gỗ MDF cao cấp GHS-2399',1,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862094,'ke-de-sach-bang-go-mdf-cao-cap-ghs-2399-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá kệ sách gỗ thiết kế đơn giản GHS-2398',1,N'hiện tại chưa có mô tả về sản phẩm',1600000,1633862094,'gia-ke-sach-go-thiet-ke-don-gian-ghs-2398-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ để sách báo gỗ MDF phủ melamine GHS-2397',1,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862094,'ke-de-sach-bao-go-mdf-phu-melamine-ghs-2397-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách đa năng kiểu dáng độc đáo GHS-2395',1,N'hiện tại chưa có mô tả về sản phẩm',2900000,1633862094,'ke-sach-da-nang-kieu-dang-doc-dao-ghs-2395-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá kệ sách bằng gỗ đa năng GHS-2394',1,N'hiện tại chưa có mô tả về sản phẩm',2400000,1633862094,'gia-ke-sach-bang-go-da-nang-ghs-2394-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách gỗ MDF phủ melamine GHS-2393',1,N'hiện tại chưa có mô tả về sản phẩm',2500000,1633862094,'ke-sach-go-mdf-phu-melamine-ghs-2393-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ giá để sách bằng gỗ tại nhà GHS-2389',1,N'hiện tại chưa có mô tả về sản phẩm',3200000,1633862094,'ke-gia-de-sach-bang-go-tai-nha-ghs-2388-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá để sách gỗ nhỏ gọn GHS-2388',1,N'hiện tại chưa có mô tả về sản phẩm',1700000,1633862094,'gia-de-sach-go-nho-gon-ghs-2388-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá để sách truyện cho bé bằng gỗ GHS-2385',1,N'hiện tại chưa có mô tả về sản phẩm',2500000,1633862094,'gia-de-sach-truyen-cho-be-bang-go-ghs-2385-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ giá sách gỗ đa năng kiểu dáng trẻ trung GHS-51598',1,N'hiện tại chưa có mô tả về sản phẩm',500000,1633862094,'ke-gia-sach-go-da-nang-kieu-dang-tre-trung-ghs-51598-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách cho bé gỗ công nghiệp cao cấp, tủ sách nhỏ GHC-1111',1,N'hiện tại chưa có mô tả về sản phẩm',1600000,1633862094,'ke-sach-cho-be-ghc-1111-3-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách nhỏ 5 tầng, tủ kệ sách gỗ công nghiệp GHC-1110',1,N'hiện tại chưa có mô tả về sản phẩm',1500000,1633862094,'ke-sach-nho-ghc-1110-9-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kể để truyện tranh, kệ giá sách gỗ MDF GHC-1108',1,N'hiện tại chưa có mô tả về sản phẩm',950000,1633862094,'ke-de-truyen-tranh-ke-gia-sach-go-mdf-ghc-1108-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách nhỏ gọn kết cấu chắc chắn GHC-1105',1,N'hiện tại chưa có mô tả về sản phẩm',1100000,1633862094,'ke-sach-nho-gon-ket-cau-chac-chan-ghc-1105-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ để đồ hình Robot bằng gỗ thiết kế mới GHC-1104',1,N'hiện tại chưa có mô tả về sản phẩm',1600000,1633862094,'ke-de-do-hinh-robot-bang-go-thiet-ke-moi-ghc-1104-ava2-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách hình robot, kệ để đồ gỗ kiểu dáng độc đáo GHC-1103',1,N'hiện tại chưa có mô tả về sản phẩm',1600000,1633862094,'ke-sach-hinh-robot-ke-de-do-go-kieu-dang-doc-dao-ghc-1103-2-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ để sách cho trẻ, kệ trang trí gỗ công nghiệp GHC-1101',1,N'hiện tại chưa có mô tả về sản phẩm',1400000,1633862094,'ke-de-sach-cho-tre-ke-trang-tri-go-cong-nghiep-ghc-1101-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách mái nhà độc đáo, kệ để đồ đẹp GHC-1100',1,N'hiện tại chưa có mô tả về sản phẩm',1100000,1633862094,'ke-sach-mai-nha-doc-dao-ke-de-do-dep-ghc-1100-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ truyện tranh cho bé, kệ trang trí gỗ MDF GHC-199',1,N'hiện tại chưa có mô tả về sản phẩm',750000,1633862094,'ke-truyen-tranh-cho-be-ke-trang-tri-go-mdf-ghc-199-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách gỗ MDF mini cho bé, kệ để đồ nhỏ gọn GHC-2425',1,N'hiện tại chưa có mô tả về sản phẩm',1100000,1633862094,'avar-2-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ trưng bày Tatami 120 cm bằng gỗ MDF GHC-2430',1,N'hiện tại chưa có mô tả về sản phẩm',1800000,1633862094,'ke-go-tatami-thiet-ke-thong-minh-tien-loi-ghc-2424-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ gỗ Tatami 90 cm thiết kế thông minh tiện lợi GHC-2424',1,N'hiện tại chưa có mô tả về sản phẩm',1500000,1633862094,'ke-go-tatami-thiet-ke-thong-minh-tien-loi-ghc-2424-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách phòng bé, kệ giá sách gỗ MDF GHC-2423',1,N'hiện tại chưa có mô tả về sản phẩm',1200000,1633862094,'gia-sach-phong-be-ke-gia-sach-go-mdf-ghc-2423-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ gỗ Tatami kiểu dáng đơn giản phong cách Nhật GHC-2422',1,N'hiện tại chưa có mô tả về sản phẩm',1600000,1633862094,'ke-go-tatami-kieu-dang-don-gian-phong-cach-nhat-ghc-2422-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ Tatami thông minh, kệ giá để đồ bằng gỗ GHC-2421',1,N'hiện tại chưa có mô tả về sản phẩm',1400000,1633862094,'ke-tatami-thong-minh-ke-gia-de-do-bang-go-ghc-2421-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách đa năng, kệ giá sách bằng gỗ MDF chắc chắn GHC-2429',1,N'hiện tại chưa có mô tả về sản phẩm',1200000,1633862095,'ke-sach-da-nang-ke-gia-sach-bang-go-mdf-chac-chan-ghc-2429-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách bằng gỗ di động, giá sách cho bé GHC-2426',1,N'hiện tại chưa có mô tả về sản phẩm',1300000,1633862095,'ke-sach-bang-go-ghc-2426-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách Tatami, kệ giá sách gỗ công nghiệp GHC-2420',1,N'hiện tại chưa có mô tả về sản phẩm',1200000,1633862095,'ke-sach-tatami-ke-gia-sach-go-cong-nghiep-ghc-2420-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá kệ sách Nhật, kệ sách gỗ 4 ngăn chứa tiện lợi GHC-2419',1,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862095,'gia-ke-sach-nhat-ke-sach-go-4-ngan-chua-tien-loi-ghc-2419-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách gỗ nhỏ gọn thiết kế đa năng GHC-2418',1,N'hiện tại chưa có mô tả về sản phẩm',950000,1633862095,'gia-sach-go-nho-gon-thiet-ke-da-nang-ghc-2418-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách gỗ, kệ trưng bày đa năng GHC-2417',1,N'hiện tại chưa có mô tả về sản phẩm',699000,1633862095,'ke-sach-go-ke-trung-bay-da-nang-ghc-2417-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách nhỏ, kệ giá sách gỗ công nghiệp GHC-2416',1,N'hiện tại chưa có mô tả về sản phẩm',399000,1633862095,'ke-sach-nho-ke-gia-sach-go-cong-nghiep-ghc-2416-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ giá sách gỗ, kệ để sách nhỏ gọn đẹp GHC-2413',1,N'hiện tại chưa có mô tả về sản phẩm',399000,1633862095,'ke-gia-sach-go-ke-de-sach-nho-gon-dep-ghc-2413-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách đứng, kệ để đồ trang trí chân gỗ tự nhiên GHC-191',1,N'hiện tại chưa có mô tả về sản phẩm',1299000,1633862095,'ke-sach-dung-ke-de-do-trang-tri-chan-go-tu-nhien-ghc-191-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách gỗ hiện đại, kệ sách thông minh GHC-2414',1,N'hiện tại chưa có mô tả về sản phẩm',699000,1633862095,'avar-kệ-sách-gỗ-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá kệ vuông, tủ đồ xếp hình tùy biến không gian GHC-2407',1,N'hiện tại chưa có mô tả về sản phẩm',199000,1633862095,'Giá-kệ-vuông-tủ-đồ-xếp-hình-tùy-biến-không-gian-GHC-2407-7-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá kệ để đồ xếp hình lắp ráp đa năng size 36cm GHC-2406',1,N'hiện tại chưa có mô tả về sản phẩm',399000,1633862095,'Giá-kệ-sách-tủ-để-đồ-xếp-hình-lắp-ráp-đa-năng-8-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách đa năng bằng gỗ công nghiệp MDF cao cấp GHC-2405',1,N'hiện tại chưa có mô tả về sản phẩm',1190000,1633862095,'gia-sach-gia-dinh-thiet-ke-da-nang-ghc-2405-9-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách đứng đẹp thiết kế nhỏ gọn GHS-2384',1,N'hiện tại chưa có mô tả về sản phẩm',1500000,1633862095,'ke-sach-dung-dep-thiet-ke-nho-gon-ghs-2384-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ sách hiện đại thiết kế sang trọng GHS-2383',1,N'hiện tại chưa có mô tả về sản phẩm',2100000,1633862095,'ke-sach-hien-dai-thiet-ke-sang-trong-ghs-2383-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách cao cấp bằng gỗ GHS-2382',1,N'hiện tại chưa có mô tả về sản phẩm',8600000,1633862095,'gia-sach-cao-cap-bang-go-ghs-2382-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách đa năng thiết kế sang trọng GHS-2381',1,N'hiện tại chưa có mô tả về sản phẩm',5800000,1633862095,'gia-sach-da-nang-thiet-ke-sang-trong-ghs-2381-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách hiện đại thiết kế thông minh GHS-2380',1,N'hiện tại chưa có mô tả về sản phẩm',2100000,1633862095,'gia-sach-hien-dai-thiet-ke-thong-minh-ghs-2380-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách gia đình kiểu dáng nhỏ gọn GHS-2379',1,N'hiện tại chưa có mô tả về sản phẩm',1700000,1633862095,'gia-sach-gia-dinh-kieu-dang-nho-gon-ghs-2379-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách bằng gỗ kiểu dáng tiện dụng GHS-2378',1,N'hiện tại chưa có mô tả về sản phẩm',2300000,1633862095,'gia-sach-bang-go-kieu-dang-tien-dung-ghs-2378-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Giá sách hiện đại thiết kế đơn giản GHS-2377',1,N'hiện tại chưa có mô tả về sản phẩm',4200000,1633862095,'gia-sach-hien-dai-thiet-ke-don-gian-ghs-2377-ava-300x300.jpg')



insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn thông minh, bàn ăn gấp gọn đa năng GHC-41223',2,N'hiện tại chưa có mô tả về sản phẩm',2999000,1633862590,'avar-7-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gấp gọn, bàn ăn gỗ thiết kế thông minh GHC-41222',2,N'hiện tại chưa có mô tả về sản phẩm',2999000,1633862590,'ban-an-gap-gon-ban-an-go-thiet-ke-thong-minh-ghc-41222-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn bằng gỗ 4 chỗ thiết kế đẹp GHS-41221',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862591,'Ban-an-bang-go-4-cho-thiet-ke-dep-GHS-41221-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gia đình phong cách hiện đại GHS-41220',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862591,'Ban-an-gia-dinh-phong-cach-hien-dai-GHS-41220-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn bằng gỗ đẹp cho gia đình GHS-41219',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862591,'ban-an-bang-go-dep-cho-gia-dinh-GHS-41219-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ sồi kiểu dáng nhỏ gọn cho gia đình GHS-41218',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862591,'Ban-an-go-soi-kieu-dang-nho-gon-cho-gia-dinh-GHS-41218-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn hiện đại gỗ sồi kiểu dáng nhỏ gọn GHS-41217',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862591,'Bo-ban-an-hien-dai-go-soi-kieu-dang-nho-gon-GHS-41217-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gia đình 4 chỗ bằng gỗ tự nhiên GHS-41216',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862591,'Ban-an-gia-dinh-4-cho-bang-go-tu-nhien-GHS-41216-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ sồi thiết kế đẹp thanh lịch GHS-41215',2,N'hiện tại chưa có mô tả về sản phẩm',14000000,1633862591,'Ban-an-go-soi-thiet-ke-dep-thanh-lich-GHS-41215-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ghế ăn gỗ chất lượng cao cho gia đình GHS-41214',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862591,'Bo-ban-ghe-an-go-chat-luong-cao-cho-gia-dinh-GHS-41214-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn bằng gỗ kiểu dáng thanh lịch GHS-41213',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862591,'ban-an-bang-go-kieu-dang-tahnh-lich-GHS-41213-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gia đình thiết kế đẹp bằng gỗ sồi GHS-41212',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862591,'Ban-an-gia-dinh-thiet-ke-dep-bang-go-soi-GHS-41212-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gia đình kiểu dáng nhỏ gọn GHS-41155',2,N'hiện tại chưa có mô tả về sản phẩm',11500000,1633862591,'Bo-ban-an-gia-dinh-kieu-dang-nho-gon-GHS-41155-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn bằng gỗ chất lượng cao GHS-41154',2,N'hiện tại chưa có mô tả về sản phẩm',14500000,1633862591,'Ban-an-bang-go-chat-luong-cao-GHS-41154-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gia đình đẹp thanh lịch GHS-41153',2,N'hiện tại chưa có mô tả về sản phẩm',14000000,1633862591,'Bo-ban-an-gia-dinh-dep-thanh-lich-GHS-41153-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hiện đại bằng gỗ cho gia đình GHS-41152',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862591,'Ban-an-hien-dai-bang-go-cho-gia-dinh-GHS-41152-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ghế ăn bằng gỗ tự nhiên GHS-41151',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862591,'Bo-ban-ghe-an-bang-go-tu-nhien-GHS-41151-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gỗ thiết kế ấn tượng GHS-41150',2,N'hiện tại chưa có mô tả về sản phẩm',13500000,1633862591,'Bo-ban-an-go-thiet-ke-an-tuong-GHS-41150-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn tròn phong cách hiện đại GHS-41149',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Bo-ban-an-tron-phong-cach-hien-dai-GHS-41149-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hiện đại cho gia đình GHS-41148',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862592,'Ban-an-hien-dai-cho-gia-dinh-GHS-41148-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gia đình bằng gỗ thiết kế đẹp GHS-41147',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Ban-an-gia-dinh-bang-go-thiet-ke-dep-GHS-41147-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ghế ăn phong cách hiện đại GHS-41146',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Bo-ban-ghe-an-phong-cach-hien-dai-GHS-41146-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hiện đại bằng gỗ cao cấp GHS-41145',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'ban-an-hien-dai-bang-go-cao-cap-GHS-41145-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn đẹp bằng gỗ tự nhiên GHS-41093',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Ban-an-dep-bang-go-tu-nhien-GHS-41093-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hình vuông bằng gỗ tự nhiên GHS-41092',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Ban-an-hinh-vuong-bang-go-tu-nhien-GHS-41092-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn chất lượng cao thiết kế đẹp GHS-41091',2,N'hiện tại chưa có mô tả về sản phẩm',14500000,1633862592,'Bo-ban-an-chat-luong-cao-thiet-ke-dep-GHS-41091-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hiện đại 4 ghế cho gia đình GHS-41090',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862592,'Ban-an-hien-dai-4-ghe-cho-gia-dinh-GHS-41090-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hiện đại thiết kế ấn tượng GHS-41089',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862592,'Ban-an-hien-dai-thiet-ke-an-tuong-GHS-41089-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ tự nhiên cao cấp GHS-41088',2,N'hiện tại chưa có mô tả về sản phẩm',14500000,1633862592,'Ban-an-go-tu-nhien-cao-cap-GHS-41088-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gỗ đẹp cho gia đình GHS-41087',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862592,'Bo-ban-an-go-dep-cho-gia-dinh-GHS-41087-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gia đình bằng gỗ tự nhiên GHS-41086',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862592,'Ban-an-gia-dinh-bang-go-tu-nhien-GHS-41086-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn bằng gỗ thiết kế đẹp GHS-41085',2,N'hiện tại chưa có mô tả về sản phẩm',13000000,1633862592,'Ban-an-bang-go-thiet-ke-dep-GHS-41085-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn hiện đại cho gia đình GHS-41084',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Bo-ban-an-hien-dai-cho-gia-dinh-GHS-41084-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gia đình thiết kế đẹp GHS-41083',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Bo-ban-an-gia-dinh-thiet-ke-dep-GHS-41083-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gỗ kiểu dáng nhỏ gọn GHS-41082',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862592,'Bo-ban-an-gi-kieu-dang-nho-gon-GHS-41082-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn bằng gỗ chất lượng cao GHS-41081',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Ban-an-bang-go-chat-luong-cao-GHS-41081-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bộ bàn ăn gỗ 4 ghế hiện đại GHS-41080',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Bo-ban-an-go-4-ghe-hien-dai-GHS-41080-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gia đình hiện đại đẹp GHS-41079',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'Ban-an-gia-dinh-hien-dai-dep-GHS-41079-ava-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ gia đình ghế bọc nỉ cao cấp GHS-4909',2,N'hiện tại chưa có mô tả về sản phẩm',11500000,1633862592,'ban-an-go-gia-dinh-ghe-boc-ni-cao-cap-ghs-4909-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ hiện đại thiết kế nhỏ gọn sang trọng GHS-4908',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862592,'ban-an-go-hien-dai-thiet-ke-nho-gon-sang-trong-ghs-4908-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ gia đình đẹp sang trọng hiện đại GHS-4905',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862592,'ban-an-go-gia-dinh-dep-sang-trong-hien-dai-ghs-4905-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ sồi gia đình thiết kế đẹp hiện đại GHS-4902',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862592,'ban-an-go-soi-gia-dinh-thiet-ke-dep-hien-dai-ghs-4902-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn hiện đại bằng gỗ sồi tự nhiên sang trọng GHS-4900',2,N'hiện tại chưa có mô tả về sản phẩm',12500000,1633862593,'ban-an-hien-dai-bang-go-soi-tu-nhien-sang-trong-ghs-4900-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ gia đình thiết kế sang trọng hiện đại GHS-4899',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862593,'ban-an-go-gia-dinh-thiet-ke-sang-trong-hien-dai-ghs-4899-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ công nghiệp nhỏ gọn tiện lợi GHS-4854',2,N'hiện tại chưa có mô tả về sản phẩm',7000000,1633862593,'ban-an-go-cong-nghiep-nho-gon-tien-loi-ghs-4854-300x300.png')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ gia đình thiết kế đẹp hiện đại GHS-4853',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862593,'ban-an-go-gia-dinh-thiet-ke-dep-hien-dai-ghs-4853-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Bàn ăn gỗ hiện đại sang trọng tiện dụng GHS-4852',2,N'hiện tại chưa có mô tả về sản phẩm',12000000,1633862593,'ban-an-go-hien-dai-sang-trong-tien-dung-ghs-4852-300x300.jpg')


insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo đơn giản nhỏ gọn, tủ áo gỗ hiện đại GHC-5724',3,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862756,'tu-quan-ao-don-gian-ghc-5724-3-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ treo quần áo 2 suốt tiện lợi, tủ áo kích thước nhỏ gọn GHC-5723',3,N'hiện tại chưa có mô tả về sản phẩm',1400000,1633862756,'tu-treo-quan-ao-ghc-5723-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo nhỏ gọn, tủ đồ gỗ công nghiệp GHC-5722',3,N'hiện tại chưa có mô tả về sản phẩm',1400000,1633862756,'tu-ao-nho-gon-ghc-5722-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ treo quần áo đa năng, tủ đồ tiện dụng GHC-5720',3,N'hiện tại chưa có mô tả về sản phẩm',1700000,1633862756,'tu-treo-quan-ao-ghc-5720-2-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Kệ đồ quần áo, tủ kệ treo áo kiểu dáng nhỏ gọn GHS-51522',3,N'hiện tại chưa có mô tả về sản phẩm',2100000,1633862756,'ke-do-quan-ao-tu-ke-treo-ao-kieu-dang-nho-gon-ghs-51480-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cho bé, tủ đừng đồ bằng gỗ công nghiệp GHC-5725',3,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862756,'tu-quan-ao-cho-be-tu-dung-do-bang-go-cong-nghiep-ghc-5725-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo gỗ kiểu nhật, tủ lưu trữ đồ đa năng GHC-51479',3,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862756,'tu-quan-ao-go-kieu-nhat-tu-luu-tru-do-da-nang-ghc-51479-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ để đồ Tatami, tủ áo kiểu Nhật bằng gỗ GHC-51478',3,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862756,'tu-de-do-tatami-tu-ao-kieu-nhat-bang-go-ghc-51471-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo Tatami gỗ thiết kế tiện dụng GHC-51469',3,N'hiện tại chưa có mô tả về sản phẩm',1900000,1633862756,'tu-ao-tatami-go-thiet-ke-tien-dung-ghc-51469-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ lưu trữ đồ, tủ quần áo gỗ công nghiệp GHC-51476',3,N'hiện tại chưa có mô tả về sản phẩm',2500000,1633862756,'tu-luu-tru-do-tu-quan-ao-go-cong-nghiep-ghc-51476-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo cho bé cánh mở hiện đại, tủ để đồ bằng gỗ GHC-2432',3,N'hiện tại chưa có mô tả về sản phẩm',1500000,1633862756,'tu-ao-cho-be-ghc-2432-10-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cho bé, tủ quần áo trẻ em đẹp GHC-51467',3,N'hiện tại chưa có mô tả về sản phẩm',1999000,1633862756,'tu-quan-ao-cho-be-GHC-51467-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo gỗ MDF, tủ quần áo kiểu dáng đơn giản GHC-51466',3,N'hiện tại chưa có mô tả về sản phẩm',1699000,1633862756,'tu-quan-ao-go-ghc-51466-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo nhỏ gọn, tủ áo bằng gỗ 3 tầng GHC-51465',3,N'hiện tại chưa có mô tả về sản phẩm',999000,1633862756,'avar-8-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo gỗ nhỏ gọn thiết kế phong cách hiện đại GHC-51473',3,N'hiện tại chưa có mô tả về sản phẩm',699000,1633862756,'tu-ao-go-nho-gon-thiet-ke-phong-cach-hien-dai-ghc-51473-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo gỗ MDF kết cấu chắc chắn phủ melamine GHC-51472',3,N'hiện tại chưa có mô tả về sản phẩm',1299000,1633862756,'tu-ao-go-mdf-ket-cau-chac-chan-phu-melamine-ghc-51472-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo gia đình, tủ để quần áo bằng gỗ tiện lợi GHC-51464',3,N'hiện tại chưa có mô tả về sản phẩm',2999000,1633862756,'tu-ao-gia-dinh-tu-de-quan-ao-bang-go-tien-loi-ghc-51464-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo gỗ MDF, tủ quần áo đơn giản đẹp GHC-51471',3,N'hiện tại chưa có mô tả về sản phẩm',1299000,1633862756,'tu-quan-ao-GHC-51471-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo gỗ nhỏ, tủ quần áo đơn 6 tầng GHC-51470',3,N'hiện tại chưa có mô tả về sản phẩm',999000,1633862756,'tu-quan-ao-GHC-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo gỗ MDF, tủ áo cho phòng nhỏ GHC-51460',3,N'hiện tại chưa có mô tả về sản phẩm',1299000,1633862756,'avar-tu-quan-ao-GHC-51460--300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo nhỏ gọn, tủ để quần áo bằng gỗ MDF GHC-51463',3,N'hiện tại chưa có mô tả về sản phẩm',1699000,1633862756,'tu-ao-nho-gon-tu-de-quan-ao-bang-go-mdf-ghc-51463-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo di động, tủ quần áo thiết kế hiện đại thông minh GHC-51462',3,N'hiện tại chưa có mô tả về sản phẩm',1699000,1633862756,'tu-ao-di-dong-tu-quan-ao-thiet-ke-hien-dai-thong-minh-ghc-51462-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo gỗ hiện đại thiết kế cánh mở GHS-51444',3,N'hiện tại chưa có mô tả về sản phẩm',6400000,1633862756,'tu-ao-go-hien-dai-thiet-ke-canh-mo-ghs-51444-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo cánh lùa bằng gỗ sồi tự nhiên GHS-51443',3,N'hiện tại chưa có mô tả về sản phẩm',15000000,1633862756,'tu-ao-canh-lua-bang-go-soi-tu-nhien-ghs-51143-ava1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo cánh chớp bằng gỗ sồi tự nhiên cao cấp GHS-51442',3,N'hiện tại chưa có mô tả về sản phẩm',15900000,1633862756,'tu-ao-canh-chop-bang-go-soi-tu-nhien-cao-cap-ghs-51442-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo cánh lùa thiết kế chớp giả GHS-51441',3,N'hiện tại chưa có mô tả về sản phẩm',15200000,1633862756,'tu-ao-canh-lua-thiet-ke-chop-gia-ghs-51441-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ để quần áo gỗ cánh chớp giả cao cấp GHS-51440',3,N'hiện tại chưa có mô tả về sản phẩm',22000000,1633862757,'tu-quan-ao-go-canh-chop-gia-cao-cap-ghs-51440-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cánh trượt bằng gỗ cao cấp GHS-51439',3,N'hiện tại chưa có mô tả về sản phẩm',8900000,1633862757,'tu-quan-ao-canh-truot-bang-go-cao-cap-ghs-51439-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo gỗ MDF cho bé gái kiểu dáng dễ thương GHS-51438',3,N'hiện tại chưa có mô tả về sản phẩm',8900000,1633862757,'tu-ao-go-mdf-cho-be-gai-kieu-dang-de-thuong-ghs-51438-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cho bé bằng gỗ công nghiệp GHS-51437',3,N'hiện tại chưa có mô tả về sản phẩm',4900000,1633862757,'tu-quan-ao-cho-be-bang-go-cong-nghiep-ghs-51437-ava-1-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo bằng gỗ thiết kế cánh mở tiện dụng GHS-51436',3,N'hiện tại chưa có mô tả về sản phẩm',13500000,1633862757,'tu-ao-bang-go-thiet-ke-canh-mo-tien-dung-ghs-51436-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo cánh mở gia đình bằng gỗ cao cấp GHS-51435',3,N'hiện tại chưa có mô tả về sản phẩm',9500000,1633862757,'tu-ao-canh-mo-gia-dinh-bang-go-cao-cap-ghs-51435-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo gia đình bằng gỗ thiết kế đẹp GHS-51434',3,N'hiện tại chưa có mô tả về sản phẩm',7900000,1633862757,'tu-ao-gia-dinh-bang-go-thiet-ke-dep-ghs-51434-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ để quần áo bằng gỗ MDF phun sơn GHS-51433',3,N'hiện tại chưa có mô tả về sản phẩm',7500000,1633862757,'tu-de-quan-ao-bang-go-mdf-phun-son-ghs-51433-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ đựng quần áo gỗ sồi sang trọng GHS-51432',3,N'hiện tại chưa có mô tả về sản phẩm',18500000,1633862757,'tu-dung-quan-ao-go-soi-sang-trong-ghs-51432-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo đẹp thiết kế cánh mở GHS-51431',3,N'hiện tại chưa có mô tả về sản phẩm',4200000,1633862757,'tu-quan-ao-dep-thiet-ke-canh-mo-ghs-51431-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ để quần áo bằng gỗ thiết kế tiện lợi GHS-51430',3,N'hiện tại chưa có mô tả về sản phẩm',4200000,1633862757,'tu-de-quan-ao-bang-go-thiet-ke-tien-loi-ghs-51430-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cánh lùa thiết kế hiện đại GHS-51429',3,N'hiện tại chưa có mô tả về sản phẩm',13200000,1633862757,'tu-quan-ao-canh-lua-thiet-ke-hien-dai-ghs-51429-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ đựng quần áo cánh mở kích thước nhỏ gọn GHS-51428',3,N'hiện tại chưa có mô tả về sản phẩm',4600000,1633862757,'tu-dung-quan-ao-canh-mo-kich-thuoc-nho-gon-ghs-51428-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo cánh mở bằng gỗ kiểu dáng nhỏ gọn GHS-51345',3,N'hiện tại chưa có mô tả về sản phẩm',7600000,1633862757,'tu-ao-canh-mo-bang-go-kieu-dang-nho-gon-ghs-51345-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ để quần áo gỗ công nghiệp kết cấu chắc chắn GHS-51344',3,N'hiện tại chưa có mô tả về sản phẩm',5700000,1633862757,'tu-de-quan-ao-go-cong-nghiep-ket-cau-chac-chan-ghs-51344-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ gỗ đựng quần áo gia đình thiết kế hiện đại GHS-51343',3,N'hiện tại chưa có mô tả về sản phẩm',8900000,1633862757,'tu-go-dung-quan-ao-gia-dinh-thiet-ke-hien-dai-ghs-51343-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ để quần áo cánh trượt gỗ MDF cốt lõi xanh GHS-51342',3,N'hiện tại chưa có mô tả về sản phẩm',8900000,1633862757,'tu-de-quan-ao-canh-truot-go-mdf-cot-loi-xanh-ghs-51342-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cánh mở gỗ MDF thiết kế hiện đại GHS-51341',3,N'hiện tại chưa có mô tả về sản phẩm',6900000,1633862757,'tu-quan-ao-canh-mo-go-mdf-thiet-ke-hien-dai-ghs-51341-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ đựng quần áo thiết kế cánh trượt triện dụng GHS-51340',3,N'hiện tại chưa có mô tả về sản phẩm',12900000,1633862757,'tu-dung-quan-ao-thiet-ke-canh-truot-trien-dung-ghs-51340-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ quần áo cánh lùa bằng gỗ kết cấu chắc chắn GHS-51339',3,N'hiện tại chưa có mô tả về sản phẩm',9300000,1633862757,'tu-quan-ao-canh-lua-bang-go-ket-cau-chac-chan-ghs-51339-ava-300x300.jpg')
insert into tblProduct (name,category_id,description,price,created_at,img) values (N'Tủ áo bằng gỗ cánh trượt thiết kế tiện lợi GHS-51338',3,N'hiện tại chưa có mô tả về sản phẩm',8900000,1633862757,'tu-ao-bang-go-canh-truot-thiet-ke-tien-loi-ghs-51338-ava-1-300x300.jpg')





select * from tblProduct limit 20

select * limit 20 from tblProduct


select top 10 * from tblProduct order by newid()

insert into tblUsers (username,password,email,role,created_at) values ('hai123456','asdasdasdasd','mitt@gmail.com',1,123123213)