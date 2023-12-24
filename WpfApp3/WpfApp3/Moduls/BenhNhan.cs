using System;
using System.Collections.Generic;

namespace WpfApp3.Moduls;

public partial class BenhNhan
{
    public int MaBn { get; set; }

    public string? HoTen { get; set; }

    public string? DiaChi { get; set; }

    public int SoNgayNamVien { get; set; }

    public double VienPhi { get; set; }

    public int MaKhoa { get; set; }

    public virtual Khoa MaKhoaNavigation { get; set; } = null!;
}
