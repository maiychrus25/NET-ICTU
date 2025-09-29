# Windows Forms CRUD Application (C# - .NET Framework + Entity Framework)

## 📌 Giới thiệu
Đây là bộ sưu tập các bài tập **Windows Forms Application** sử dụng **C#** và **Entity Framework** để kết nối **SQL Server**.  
Ứng dụng minh họa cách xây dựng giao diện quản lý dữ liệu và các chức năng **CRUD** (Create, Read, Update, Delete) cơ bản.  

Mỗi đề tài sẽ quản lý một đối tượng khác nhau, ví dụ:
- Quản lý kho hàng (Inventory)
- Quản lý dự án (Project)
- Quản lý phòng ban (Department)
- Quản lý nhà phân phối (Distributor)
- Quản lý tác giả (Author)
- Quản lý bài báo (Article)
- Quản lý nhà xuất bản (Publisher)
- Quản lý lớp học (Class)
- Quản lý học sinh (Student)

---

## 🖼️ Giao diện
Form chính gồm:
- Các **TextBox** để nhập dữ liệu
- **DataGridView** hiển thị toàn bộ dữ liệu
- Các **Button** (Thêm, Sửa, Xóa, Lưu, Tìm kiếm)
- TextBox **ID** được đặt **ReadOnly = true** để không chỉnh sửa

---

## ⚙️ Cấu trúc dự án
```plaintext
├── Models
│   ├── EntityClass.cs          # Lớp chính (Inventory / Project / ...)
│   ├── EntityDbContext.cs      # DbContext kết nối SQL Server
│
├── Form1.cs                    # Code xử lý logic giao diện
├── Form1.Designer.cs           # File thiết kế giao diện
├── Program.cs                  # Điểm khởi chạy ứng dụng
```

---

## 🚀 Hướng dẫn chạy
### 1. Cấu hình SQL Server
- Tạo một database mới, ví dụ `WinFormsDemo`
- Chạy script tạo bảng tương ứng, ví dụ:
```sql
CREATE TABLE Inventories (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    Quantity INT,
    Location NVARCHAR(100),
    Description NVARCHAR(MAX)
);
```

### 2. Cấu hình `DbContext`
Trong file `EntityDbContext.cs`, chỉnh lại chuỗi kết nối:
```csharp
protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
{
    optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=WinFormsDemo;Trusted_Connection=True;");
}
```

### 3. Chạy ứng dụng
- Mở project bằng **Visual Studio**
- Chọn **Set as Startup Project**
- Nhấn **F5** để chạy

---

## ✨ Chức năng chính
- **Thêm mới** bản ghi
- **Xem toàn bộ** dữ liệu trong DataGridView
- **Chỉnh sửa** bản ghi đã chọn
- **Xóa** bản ghi
- **Tìm kiếm** theo tên (hoặc tiêu đề, tùy đối tượng)

---

## 📖 Ví dụ lớp Entity
Ví dụ với `Inventory`:
```csharp
public class Inventory
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
}
```

---

## 📌 Lưu ý
- Đây là bài tập mẫu cho môn **Lập trình Windows Forms với C#**
- Có thể nhân bản và sửa tên entity để áp dụng cho nhiều bài tập khác nhau
