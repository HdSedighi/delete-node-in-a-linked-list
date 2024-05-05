# Intuition
The problem requires deleting a node from a singly linked list without having access to the head node of the list. Instead, we're given direct access to the node that needs to be deleted. The linked list contains unique values, and the node to be deleted is not the last node in the list. Since the node to be deleted isn't the last node, we can handle the deletion by replacing the current node's value and next pointer with the value and next pointer of its next node. This approach allows us to remove the desired node from the list without modifying any previous nodes.

# Approach
Given a node to delete, we replace the node's value and next pointer with the value and next pointer of the next node. This way, the current node essentially becomes the next node, effectively removing the node from the linked list. This operation is efficient as it only involves manipulating the node's value and next pointer.

# Complexity
- Time complexity:
The time complexity of deleting a node in a singly linked list using this approach is O(1) since it only requires a constant amount of time to copy the value and next pointer from the next node to the current node.
- Space complexity:
The space complexity of this operation is O(1) because no additional space is needed apart from a temporary variable (if used) to perform the operation. The function modifies the linked list in place without requiring any extra storage.
