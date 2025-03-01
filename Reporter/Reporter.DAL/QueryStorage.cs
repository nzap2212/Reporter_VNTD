using System.Collections.Generic;

namespace Reporter.DAL
{
    public static class QueryStorage
    {
        public static readonly string GET_TOTAL_COUNT = @"
        SELECT 
            (SELECT COUNT(*) 
            FROM NoiTru_LuuTru lt
            WHERE (lt.PhongBan_Id IN ({0})) 
            AND LyDoVao_Code='NM' 
            AND lt.thoigianvao  BETWEEN @StartDate1 AND @EndDate1) 
        +
            (SELECT COUNT(*) 
             FROM KhamBenh kb 
             WHERE kb.ThoiGiankham BETWEEN @StartDate2 AND @EndDate2)
        +
            (SELECT COUNT(*)
            FROM KSK_HopDong hd
            LEFT JOIN KSK_HopDong_BenhNhan bn ON hd.HopDong_ID=bn.HopDong_id
            WHERE hd.ThoiGiankham BETWEEN @StartDate3 AND @EndDate3)
        AS TotalCount;";
    }
}
