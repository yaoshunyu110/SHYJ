using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZJSoft.DbHelper.DataAccess;


namespace ZJ_ECS_JLX_COS.Model
{
      [DbTab("WMS_W_Task","ID")]
      public class WMS_W_Task
      {
            /// <summary>
            /// �������
            /// </summary>
            [DbBind("ID")]
            public string ID { set; get; }
            /// <summary>
            /// �������/��������
            /// </summary>
            [DbBind("Barcode")]
            public string Barcode { set; get; }
            /// <summary>
            /// ����ʱ��
            /// </summary>
            [DbBind("ImportTime")]
            public string ImportTime { set; get; }
            /// <summary>
            /// ������
            /// </summary>
            [DbBind("ImportUserId")]
            public string ImportUserId { set; get; }
            /// <summary>
            /// --Status WMS_W_Ttask �����״̬ 
     /// </summary>
            [DbBind("Status")]
            public string Status { set; get; }
            /// <summary>
            /// �ϴ�Erp ��ʶ  Ĭ��0��null,1-�����Ѹ��´��ϴ�,2-�ϴ�Erp���
            /// </summary>
            [DbBind("UpdateFlag")]
            public string UpdateFlag { set; get; }
            /// <summary>
            /// ������Դ 0-ERP����,1-���ش���
            /// </summary>
            [DbBind("DataSources")]
            public string DataSources { set; get; }
            /// <summary>
            /// ��������ID
            /// </summary>
            [DbBind("TaskId")]
            public string TaskId { set; get; }
            /// <summary>
            /// ��Ӧ�̽�������
            /// </summary>
            [DbBind("EIRNumber")]
            public string EIRNumber { set; get; }
            /// <summary>
            /// ���ϱ���
            /// </summary>
            [DbBind("MaterialId")]
            public string MaterialId { set; get; }
            /// <summary>
            /// ��������
            /// </summary>
            [DbBind("MaterialName")]
            public string MaterialName { set; get; }
            /// <summary>
            /// ��������
            /// </summary>
            [DbBind("RequestQuantity")]
            public string RequestQuantity { set; get; }
            /// <summary>
            /// �������������������
            /// </summary>
            [DbBind("CompledQuantity")]
            public string CompledQuantity { set; get; }
            /// <summary>
            /// �������
   
            /// </summary>
            [DbBind("InvQuantity")]
            public string InvQuantity { set; get; }
            /// <summary>
            /// ��/�����ʶ
  
            /// </summary>
            [DbBind("InOutFlag")]
            public string InOutFlag { set; get; }
            /// <summary>
            /// ������ʶ
            /// </summary>
            [DbBind("StoreTypeFlag")]
            public string StoreTypeFlag { set; get; }
            /// <summary>
            /// ���/�ͼ�

            /// </summary>
            [DbBind("ExamineFlag")]
            public string ExamineFlag { set; get; }
            /// <summary>
            /// ����
            /// </summary>
            [DbBind("BatchNo")]
            public string BatchNo { set; get; }
            /// <summary>
            /// ����/�Ǽ���
            /// </summary>
            [DbBind("ConsignmentFlag")]
            public string ConsignmentFlag { set; get; }
            /// <summary>
            /// ����/�ǽ���
            /// </summary>
            [DbBind("ImportFlag")]
            public string ImportFlag { set; get; }
            /// <summary>
            /// ����
            /// </summary>
            [DbBind("BillNo")]
            public string BillNo { set; get; }
            /// <summary>
            /// ��λ
            /// </summary>
            [DbBind("Position")]
            public string Position { set; get; }
            /// <summary>
            /// ��������
            /// </summary>
            [DbBind("ComponentCode")]
            public string ComponentCode { set; get; }
            /// <summary>
            /// ��ȱ����:��ⵥ��ʱ��SAP��д��Ҫ��ȱ���������ⵥ��ʱ��WMS��д�Ѿ�����Ĳ�ȱ������
            /// </summary>
            [DbBind("VacancyQuantity")]
            public string VacancyQuantity { set; get; }
            /// <summary>
            /// ���ű���
            /// </summary>
            [DbBind("DepartmentCode")]
            public string DepartmentCode { set; get; }
            /// <summary>
            /// ������
            /// </summary>
            [DbBind("Operator")]
            public string Operator { set; get; }
            /// <summary>
            /// ������
            /// </summary>
            [DbBind("WorkOrder")]
            public string WorkOrder { set; get; }
            /// <summary>
            /// ����ʱ��
            /// </summary>
            [DbBind("CreatedTime")]
            public string CreatedTime { set; get; }
            /// <summary>
            /// �Ӽ�
  
            /// </summary>
            [DbBind("UrgentFlag")]
            public string UrgentFlag { set; get; }
            /// <summary>
            /// ������
            /// </summary>
            [DbBind("OrderNo")]
            public string OrderNo { set; get; }
            /// <summary>
            /// �к�
            /// </summary>
            [DbBind("ItemNo")]
            public string ItemNo { set; get; }
            /// <summary>
            /// ABC��ʶ
            /// </summary>
            [DbBind("ABCFlag")]
            public string ABCFlag { set; get; }
            /// <summary>
            /// ����ɫ
            /// </summary>
            [DbBind("PaintColor")]
            public string PaintColor { set; get; }
            /// <summary>
            /// �������
            /// </summary>
            [DbBind("SpecialProtection")]
            public string SpecialProtection { set; get; }
            /// <summary>
            /// ����
            /// </summary>
            [DbBind("EquipmentModel")]
            public string EquipmentModel { set; get; }
            /// <summary>
            /// ���
            /// </summary>
            [DbBind("Volume")]
            public string Volume { set; get; }
            /// <summary>
            /// ��һ�����ս��
            /// </summary>
            [DbBind("FirstAcceptanceQuantity")]
            public string FirstAcceptanceQuantity { set; get; }
            /// <summary>
            /// �ϸ���
            /// </summary>
            [DbBind("QualifiedQuantity")]
            public string QualifiedQuantity { set; get; }
            /// <summary>
            /// �ڶ������ս��
            /// </summary>
            [DbBind("SecondAcceptanceQuantity")]
            public string SecondAcceptanceQuantity { set; get; }
            /// <summary>
            /// ��ⵥ��
            /// </summary>
            [DbBind("DocumentNO")]
            public string DocumentNO { set; get; }
            /// <summary>
            /// ���ջ���
            /// </summary>
            [DbBind("CheckNumUserId")]
            public string CheckNumUserId { set; get; }
            /// <summary>
            /// ��������
            /// </summary>
            [DbBind("CheckNumDate")]
            public string CheckNumDate { set; get; }
            /// <summary>
            /// 
            /// </summary>
            [DbBind("CheckNumUserId_1")]
            public string CheckNumUserId_1 { set; get; }
            /// <summary>
            /// ��������ţ���ERP���������뱾���������Ա��Ҫ��������ʱ������ͨ���������������µĳ�������WMS_W_Task����ͬʱ�ڱ���������Ĵ��ֶ�д�벢�����������ţ�δ����������Ĵ��ֶ�Ϊ�ա�

            /// </summary>
            [DbBind("CombinedTask")]
            public string CombinedTask { set; get; }
            /// <summary>
            /// �Ƿ�Ϊ���� 1-�� 0��
            /// </summary>
            [DbBind("IsMerge")]
            public string IsMerge { set; get; }
            /// <summary>
            /// ��չ����1  �����������˹����ӵı�ע
            /// </summary>
            [DbBind("ExtAttr1")]
            public string ExtAttr1 { set; get; }
            /// <summary>
            /// ��չ����2����������ֽ���ɣ������ѷֽ�������������治���¼ʵ�ʷֽ��������û��棬���ֶβ�����
            /// </summary>
            [DbBind("ExtAttr2")]
            public string ExtAttr2 { set; get; }
            /// <summary>
            /// ������ɫ��������ʱ �����ݴ���ɫ���в�ѯ���㣬Ĭ��ɫ'00'
            /// </summary>
            [DbBind("Color_F")]
            public string Color_F { set; get; }
            /// <summary>
            /// ��ע˵��
            /// </summary>
            [DbBind("Remark")]
            public string Remark { set; get; }
            /// <summary>
            /// ͼ��
            /// </summary>
            [DbBind("PartDwg_No")]
            public string PartDwg_No { set; get; }
            /// <summary>
            /// �ύ���Σ�����ֽ�����ʱ���ݸ��ֶβ�ѯ�����ύ������
            /// </summary>
            [DbBind("TaskFlag")]
            public string TaskFlag { set; get; }
            /// <summary>
            /// 
            /// </summary>
            [DbBind("Required_Date")]
            public string Required_Date { set; get; }
            /// <summary>
            /// �ֽ�˵��
            /// </summary>
            [DbBind("ResolveRemark")]
            public string ResolveRemark { set; get; }
            /// <summary>
            /// SAP�����ʶ����⣺ 

            /// </summary>
            [DbBind("CheckFlag")]
            public string CheckFlag { set; get; }
            /// <summary>
            /// ����ڷ��ࣨ����ϲ�ʱ�˹�ѡ��δ�ֽ�ǰ�ɵ�����
            /// </summary>
            [DbBind("OutLocType")]
            public string OutLocType { set; get; }
            /// <summary>
            /// ������ţ�����ϲ�����ʱ�˹���д�������ɵ�����
            /// </summary>
            [DbBind("Seq")]
            public string Seq { set; get; }
            /// <summary>
            /// ���ʱ��
            /// </summary>
            [DbBind("CompletedTime")]
            public string CompletedTime { set; get; }
      }
}
