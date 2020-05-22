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
            /// 任务ID
            /// </summary>
            [DbBind("TaskId")]
            public string TaskId { set; get; }
            /// <summary>
            /// 任务类型
 //  1-立库入库
 //  2-立库出库
 //  3-立库盘点，
 //  7-立库紧急出库
 //  8-拣货后入缓存区
 //  9-缓存区出库
 //，4-入库变更任务
            /// </summary>
            [DbBind("TaskType")]
            public string TaskType { set; get; }
            /// <summary>
            /// WMS任务ID
//WMSTaskType=1即出入库任务时 为WMS_W_Task表中WMS任务ID
//   入库时为空，有PDA扫码完成后自己创建
//   出库时为出库WMS任务号
//WMSTaskType=2即盘点任务时为WMS_W_TaskInv表TaskId
   
            /// </summary>
            [DbBind("WMSTaskId")]
            public string WMSTaskId { set; get; }
            /// <summary>
            /// 容器编号
            /// </summary>
            [DbBind("PalletNo")]
            public string PalletNo { set; get; }
            /// <summary>
            /// 起始位置
            /// </summary>
            [DbBind("SourceLoc")]
            public string SourceLoc { set; get; }
            /// <summary>
            /// 目标位置
   //目标位置可以为空，为空时由WCS计算终点站
   //         /// </summary>
   //         [DbBind("TargetLoc")]
            public string TargetLoc { set; get; }
            /// <summary>
            /// 任务状态：0-创建中，1-待执行（已创建），2-执行中，3-已完成，4-故障，5-已取消，6-强制完成
            /// </summary>
            [DbBind("Status")]
            public string Status { set; get; }
            /// <summary>
            /// 创建方式
   //1-WMS
   //2-PDA  3-WCS自动创建 4-异常处理自动创建
            /// </summary>
            [DbBind("CreateMode")]
            public string CreateMode { set; get; }
            /// <summary>
            /// 顺序号
            /// </summary>
            [DbBind("Seq")]
            public string Seq { set; get; }
            /// <summary>
            /// 创建时间
            /// </summary>
            [DbBind("CratedTime")]
            public string CratedTime { set; get; }
            /// <summary>
            /// 完成时间
            /// </summary>
            [DbBind("CompletedTime")]
            public string CompletedTime { set; get; }
            /// <summary>
            /// 优先级
   //1一般，
   //2-同条件优先处理，
   //3-紧急处理
            /// </summary>
            [DbBind("Priority_Flag")]
            public string Priority_Flag { set; get; }
            /// <summary>
            /// 任务批次号：YYYYMMDDHHmmss
            /// </summary>
            [DbBind("TaskBatchNum")]
            public string TaskBatchNum { set; get; }
            /// <summary>
            /// 使用空间
            /// </summary>
            [DbBind("UseSpace")]
            public string UseSpace { set; get; }
            /// <summary>
            /// 存储尺寸类型（数据字典）：1-正常；2-高;
            /// </summary>
            [DbBind("StorageType")]
            public string StorageType { set; get; }
            /// <summary>
            /// 创建人员
            /// </summary>
            [DbBind("CreateUser")]
            public string CreateUser { set; get; }
            /// <summary>
            /// 修改人员
            /// </summary>
            [DbBind("EditUser")]
            public string EditUser { set; get; }
            /// <summary>
            /// 修改时间
            /// </summary>
            [DbBind("EditTime")]
            public string EditTime { set; get; }
            /// <summary>
            /// 部件编号/订单号：
//入库任务时，在item里面用字段ComponentCode存放ComponentCode（部件编号）内容 ；
//其中，有部件编号的存部件编号，无部件编号的存物料的空间占用率；
//不含部件编号的物料按照同一空间占用率存放一起；
//出库任务时，在item里面用字段ComponentCode存放OrderNo（订单号）内容
            /// </summary>
            [DbBind("ComponentCode")]
            public string ComponentCode { set; get; }
            /// <summary>
            /// 绑定标识：1，2，3，4，0；
//物料出库任务时此值保持默认0；
//入库前，生成出空箱(半箱)任务时，初始值为1；物料与空箱绑定处理完成后生产入库任务时，该值修改为2；
//盘点出库时该标识为3；
//空箱出库时该标识为4；

//--出库作业都为0，入库作业中呼叫出空箱时为1，入库作业中绑定完成入库时为2，盘点作业是为3，空箱出入库为4
            /// </summary>
            [DbBind("Binding_Flag")]
            public string Binding_Flag { set; get; }
            /// <summary>
            /// WMS任务类型
//：1-WMS出入库任务；2-WMS盘点任务，默认为1，用来区分该任务是正常出入库任务还是盘点任务，在相关过程处理主任务相关数据时做判断用，3为抽盘或临时出入库任务
            /// </summary>
            [DbBind("WMSTaskType")]
            public string WMSTaskType { set; get; }
            /// <summary>
            /// 记录相关取消或强制完成说明
            /// </summary>
            [DbBind("Remark")]
            public string Remark { set; get; }
      }
}
