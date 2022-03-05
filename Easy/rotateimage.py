class Solution:
    
    def transpose(self, matrix: List[List[int]]):
        length = len(matrix)
        for index_i in range(length):
            for index_j in range(index_i, length):
                matrix[index_j][index_i], matrix[index_i][index_j] = matrix[index_i][index_j], matrix[index_j][index_i]
                
        return matrix
    
    def rotate(self, matrix: List[List[int]]) -> None:
        """
        Do not return anything, modify matrix in-place instead.
        """
    
        matrix = self.transpose(matrix)

        for row_index, row_value in enumerate(matrix):
            matrix[row_index] = row_value[::-1]
    
    

                
    
