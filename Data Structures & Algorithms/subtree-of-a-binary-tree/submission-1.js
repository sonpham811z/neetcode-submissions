class Solution {
    goToRootSubTree(root, subRoot) {
        if (root === null) return null;

        if (root.val === subRoot.val) {
            return root;
        }

        let leftRoot = this.goToRootSubTree(root.left, subRoot);
        if (leftRoot !== null) return leftRoot;

        let rightRoot = this.goToRootSubTree(root.right, subRoot);
        if (rightRoot !== null) return rightRoot;

        return null;
    }

    isSameTree(p, q) {
        if (p === null && q === null) return true;
        if (p === null || q === null) return false;
        if (p.val !== q.val) return false;

        return this.isSameTree(p.left, q.left) && this.isSameTree(p.right, q.right);
    }

    isSubtree(root, subRoot) {
        if (root === null) return false;

        // Nếu tìm thấy node có giá trị bằng root của subRoot
        if (root.val === subRoot.val && this.isSameTree(root, subRoot)) {
            return true;
        }

        // Tiếp tục tìm ở cây con trái hoặc phải
        return this.isSubtree(root.left, subRoot) || this.isSubtree(root.right, subRoot);
    }
}
