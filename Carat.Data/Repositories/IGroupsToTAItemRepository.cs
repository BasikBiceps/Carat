﻿using System.Collections.Generic;
using Carat.Data.Entities;

namespace Carat.Data.Repositories
{
    public interface IGroupsToTAItemRepository
    {
        List<GroupsToTAItem> GetAllGroupsToTAItem();
        List<GroupsToTAItem> GetGroupsToTAItem(int TAItemId);
        GroupsToTAItem GetGroupsToTAItem(int TAItemId, int groupId);
        List<GroupsToTAItem> GetGroupsToTAItems(int groupIds);
        void AddGroupsToTAItem(GroupsToTAItem groupsToTAItem);
        void RemoveGroupsToTAItem(GroupsToTAItem groupsToTAItem);
        void RemoveGroupsToTAItems(List<GroupsToTAItem> groupsToTAItems);
        void UpdateGroupsToTAItem(GroupsToTAItem groupsToTAItem);
        void DeleteAllGroupsToTAItem();
    }
}
