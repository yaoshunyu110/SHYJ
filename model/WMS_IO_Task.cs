using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZJSoft.DbHelper.DataAccess;
namespace ZJ_ECS_JLX_COS.Model
{
      [DbTab("WMS_IO_Task","ID")]
      public class WMS_IO_Task
      {
            /// <summary>
            /// 
            /// </summary>
            [DbBind("ID")]
            public string ID { set; get; }
            /// <summary>
            /// ����ID
            /// </summary>
            [DbBind("TaskId")]
            public string TaskId { set; get; }
            /// <summary>
            /// ��������
 //  1-�������
 //  2-�������
 //  3-�����̵㣬
 //  7-�����������
 //  8-������뻺����
 //  9-����������
 //��4-���������
            /// </summary>
            [DbBind("TaskType")]
            public string TaskType { set; get; }
            /// <summary>
            /// WMS����ID
//WMSTaskType=1�����������ʱ ΪWMS_W_Task����WMS����ID
//   ���ʱΪ�գ���PDAɨ����ɺ��Լ�����
//   ����ʱΪ����WMS�����
//WMSTaskType=2���̵�����ʱΪWMS_W_TaskInv��TaskId
   
            /// </summary>
            [DbBind("WMSTaskId")]
            public string WMSTaskId { set; get; }
            /// <summary>
            /// �������
            /// </summary>
            [DbBind("PalletNo")]
            public string PalletNo { set; get; }
            /// <summary>
            /// ��ʼλ��
            /// </summary>
            [DbBind("SourceLoc")]
            public string SourceLoc { set; get; }
            /// <summary>
            /// Ŀ��λ��
   //Ŀ��λ�ÿ���Ϊ�գ�Ϊ��ʱ��WCS�����յ�վ
   //         /// </summary>
   //         [DbBind("TargetLoc")]
            public string TargetLoc { set; get; }
            /// <summary>
            /// ����״̬��0-�����У�1-��ִ�У��Ѵ�������2-ִ���У�3-����ɣ�4-���ϣ�5-��ȡ����6-ǿ�����
            /// </summary>
            [DbBind("Status")]
            public string Status { set; get; }
            /// <summary>
            /// ������ʽ
   //1-WMS
   //2-PDA  3-WCS�Զ����� 4-�쳣�����Զ�����
            /// </summary>
            [DbBind("CreateMode")]
            public string CreateMode { set; get; }
            /// <summary>
            /// ˳���
            /// </summary>
            [DbBind("Seq")]
            public string Seq { set; get; }
            /// <summary>
            /// ����ʱ��
            /// </summary>
            [DbBind("CratedTime")]
            public string CratedTime { set; get; }
            /// <summary>
            /// ���ʱ��
            /// </summary>
            [DbBind("CompletedTime")]
            public string CompletedTime { set; get; }
            /// <summary>
            /// ���ȼ�
   //1һ�㣬
   //2-ͬ�������ȴ���
   //3-��������
            /// </summary>
            [DbBind("Priority_Flag")]
            public string Priority_Flag { set; get; }
            /// <summary>
            /// �������κţ�YYYYMMDDHHmmss
            /// </summary>
            [DbBind("TaskBatchNum")]
            public string TaskBatchNum { set; get; }
            /// <summary>
            /// ʹ�ÿռ�
            /// </summary>
            [DbBind("UseSpace")]
            public string UseSpace { set; get; }
            /// <summary>
            /// �洢�ߴ����ͣ������ֵ䣩��1-������2-��;
            /// </summary>
            [DbBind("StorageType")]
            public string StorageType { set; get; }
            /// <summary>
            /// ������Ա
            /// </summary>
            [DbBind("CreateUser")]
            public string CreateUser { set; get; }
            /// <summary>
            /// �޸���Ա
            /// </summary>
            [DbBind("EditUser")]
            public string EditUser { set; get; }
            /// <summary>
            /// �޸�ʱ��
            /// </summary>
            [DbBind("EditTime")]
            public string EditTime { set; get; }
            /// <summary>
            /// �������/�����ţ�
//�������ʱ����item�������ֶ�ComponentCode���ComponentCode��������ţ����� ��
//���У��в�����ŵĴ沿����ţ��޲�����ŵĴ����ϵĿռ�ռ���ʣ�
//����������ŵ����ϰ���ͬһ�ռ�ռ���ʴ��һ��
//��������ʱ����item�������ֶ�ComponentCode���OrderNo�������ţ�����
            /// </summary>
            [DbBind("ComponentCode")]
            public string ComponentCode { set; get; }
            /// <summary>
            /// �󶨱�ʶ��1��2��3��4��0��
//���ϳ�������ʱ��ֵ����Ĭ��0��
//���ǰ�����ɳ�����(����)����ʱ����ʼֵΪ1�����������󶨴�����ɺ������������ʱ����ֵ�޸�Ϊ2��
//�̵����ʱ�ñ�ʶΪ3��
//�������ʱ�ñ�ʶΪ4��

//--������ҵ��Ϊ0�������ҵ�к��г�����ʱΪ1�������ҵ�а�������ʱΪ2���̵���ҵ��Ϊ3����������Ϊ4
            /// </summary>
            [DbBind("Binding_Flag")]
            public string Binding_Flag { set; get; }
            /// <summary>
            /// WMS��������
//��1-WMS���������2-WMS�̵�����Ĭ��Ϊ1���������ָ�����������������������̵���������ع��̴����������������ʱ���ж��ã�3Ϊ���̻���ʱ���������
            /// </summary>
            [DbBind("WMSTaskType")]
            public string WMSTaskType { set; get; }
            /// <summary>
            /// ��¼���ȡ����ǿ�����˵��
            /// </summary>
            [DbBind("Remark")]
            public string Remark { set; get; }
      }
}
