﻿using Newtouch.HIS.Domain.Entity;
using Newtouch.HIS.Domain.IDomainServices;
using Newtouch.HIS.Domain.IRepository;
using Newtouch.Tools;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;
using Newtouch.Common;

namespace Newtouch.HIS.Base.HOSP.Controllers
{
    public class ItemsTypeController : ControllerBase
    {
        private readonly ISysItemsDetailRepository _sysItemsDetailRepository;
        private readonly ISysItemsRepository _sysItemsRepository;
        private readonly IItemDmnService _itemDmnService;
        public ItemsTypeController(ISysItemsDetailRepository sysItemsDetailRepository
            , ISysItemsRepository sysItemsRepository
            , IItemDmnService itemDmnService)
        {
            this._sysItemsDetailRepository = sysItemsDetailRepository;
            this._sysItemsRepository = sysItemsRepository;
            this._itemDmnService = itemDmnService;
        }

        //左导航
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeJson()
        {
            var data = _sysItemsRepository.GetValidList();
            var treeList = new List<TreeViewModel>();
            foreach (SysItemsEntity item in data)
            {
                TreeViewModel tree = new TreeViewModel();
                bool hasChildren = data.Count(t => t.ParentId == item.Id) == 0 ? false : true;
                tree.id = item.Id;
                tree.text = item.Name;
                tree.value = item.Code;
                tree.parentId = item.ParentId;
                tree.isexpand = true;
                tree.complete = true;
                tree.hasChildren = hasChildren;
                treeList.Add(tree);
            }
            return Content(treeList.TreeViewJson(null));
        }

        //gridjson
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetTreeGridJson(string keyword)
        {
            var data = _sysItemsRepository.GetList();
            if (!string.IsNullOrEmpty(keyword))
            {
                data = data.ToList().TreeWhere(t => t.Name.Contains(keyword) || t.Code.Contains(keyword), parentId: "ParentId");
            }
            var treeList = new List<TreeGridModel>();
            foreach (SysItemsEntity item in data)
            {
                TreeGridModel treeModel = new TreeGridModel();
                bool hasChildren = data.Any(t => t.ParentId == item.Id);
                treeModel.id = item.Id;
                treeModel.isLeaf = hasChildren;
                treeModel.parentId = item.ParentId;
                treeModel.expanded = hasChildren;
                treeModel.entityJson = item.ToJson();
                treeList.Add(treeModel);
            }
            return Content(treeList.TreeGridJson(null));
        }

    }
}