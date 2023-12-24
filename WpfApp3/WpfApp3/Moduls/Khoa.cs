using System;
using System.Collections.Generic;

namespace WpfApp3.Moduls;

public partial class Khoa
{
    public int MaKhoa { get; set; }

    public string TenKhoa { get; set; } = null!;

    public virtual ICollection<BenhNhan> BenhNhans { get; set; } = new List<BenhNhan>();
}
