using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDPSFamiliesExcelReporter
{
    public  class Options
    {
        internal readonly static  String HIMSELF = "نفسه (رب الاسرة)";
        internal readonly static String WIFE = "زوجة";
        internal readonly static String SON = "ابن";
        internal  readonly static String DAUGHTER = "ابنه";
        internal  readonly static String SON_DAUGHTER = "ابن/ابنه";

        internal readonly static String Male = "ذكر";
        internal readonly static String Female = "انثي";


        internal static String ADD = "إضافة";
        internal static String DELETE = "حذف";
        internal static String UPDATE = "تعديل";
        internal static String SAVE_SUCCESFULLY = "تمت عملية حفظ المعلومات بنجاح";
        internal static String EXPORT_TO_EXCEL_SUCCESFULLY = "تمت عملية التصدير لملف إكسل بنجاح";
        internal static String DefaultRelation = "حدد العلاقة";

        internal static String Pregnant_woman = "Pregnant woman \nالنساء الحوامل";
        internal static String Serious_medical = "Serious medical/health condition \nالحالات الطبية / الصحية الحرجة";
        internal static String Physical_disability = "Person with disability – physical disability \nذوي الاعاقات الحركية";
        internal static String Visual_impairment = "Person with disability – visual impairment \nذوي الاعاقات البصرية";
        internal static String Hearing_impairment = "Person with disability – hearing impairment \nذوي الاعاقات السمعية";
        internal static String Intellectual_disability = "Person with disability – intellectual disability  \nذوي الاعاقة الذهنية";
        internal static String Female_Head_of_Household = "Female Head of Household \nارباب الاسر من النساء ";
        internal static String Unaccompanied_child = "Unaccompanied child head of household  \nرب اسرة طفل غير مصحوب بأحد ";
        internal static String Separated_child = "Separated child \nطفل منفصل ";
        internal static String Older_person = "Older person (60+)  \nكبار السن  ";
        internal static String Child_headed_household = "Child headed household\n الاسرة التي يقودها طفل  ";



        internal static void Error(string msg)
        {
            MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal static void Info()
        {
            MessageBox.Show(SAVE_SUCCESFULLY, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
