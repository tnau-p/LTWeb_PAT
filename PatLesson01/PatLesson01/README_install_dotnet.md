Hướng dẫn nhanh: Cài .NET SDK cho Windows (tự động bằng script không cần admin)

1) Mở PowerShell (không cần admin, nhưng chạy as Administrator nếu muốn).

2) Chạy lệnh sau để cho phép script tạm thời và thực thi script cài đặt (nếu bạn đặt file trong thư mục project):

```powershell
Set-ExecutionPolicy Bypass -Scope Process -Force
.\install-dotnet.ps1 -Channel latest
```

- Tham số `-Channel` có thể là `latest`, `lts`, hoặc `preview`.
- Script sẽ tải `dotnet-install.ps1` từ Microsoft và cài SDK vào `%USERPROFILE%\\.dotnet`.
- Script sẽ thêm `%USERPROFILE%\\.dotnet` và `%USERPROFILE%\\.dotnet\\tools` vào PATH người dùng (bằng `setx`). Bạn cần khởi động lại terminal hoặc đăng xuất/đăng nhập lại để thấy thay đổi.

3) Sau khi mở lại terminal, kiểm tra:

```powershell
dotnet --info
```

4) Vào thư mục project và chạy:

```powershell
cd "d:\Study\Năm 3 Kỳ 1\Lập Trình Web\LTWeb_PAT\PatLesson01\PatLesson01"
dotnet run
```

Nếu bạn muốn, tôi có thể hướng dẫn từng bước qua màn hình, hoặc tạo script chạy tự động download+chạy (yêu cầu bạn cho phép thực thi).