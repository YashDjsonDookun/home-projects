#include <iostream>
#include <string>

int main()
{
        int arr[] = {4,45,1,127,69,2,18};
	int arrSize = (sizeof(arr)) / sizeof(*arr);
	int temp;

	for (int i=0; i < arrSize; i++)
	{
		std::cout << arr[i] <<std::endl;
	}

	for (int i=0; i < arrSize; i++)
	{
		for (int j=0; j < arrSize -1; j++)
		{
			temp = arr[j];
			arr[j] = arr[j+1];
			arr[j+1] = temp;
		}
	}

	for (int i=0; i < arrSize; i++)
        {
                std::cout << arr[i] <<std::endl;
        }

        return 0;
}

