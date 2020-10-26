function part2ConfM(trueLabels, predictionMatrix, kValue, valueArray)

predictions = predictionMatrix(kValue,:);

noOfPredictions = size(predictions,2);
noOfValues = size(valueArray,1);
confusionMatrix = zeros(noOfValues,noOfValues);
labels = zeros(noOfValues,1);

for i = 1:noOfValues
    labels(i) = valueArray(i);
end

for i = 1:noOfPredictions
    rowNo = 0;
    colNo = 0;
    if predictions(1,i) == trueLabels(i,1)
        for j = 1:noOfValues
            if trueLabels(i,1) == labels(j)
                rowNo = j;
            end
        end
        confusionMatrix(rowNo,rowNo) = confusionMatrix(rowNo,rowNo) + 1;
    else
        for j=1:noOfValues
            if predictions(1,i) == labels(j)
                colNo = j;
            end
        end
        for j=1:noOfValues
            if trueLabels(i,1) == labels(j)
                rowNo = j;
            end
        end
        confusionMatrix(rowNo,colNo) = confusionMatrix(rowNo,colNo) + 1;    
           
    end
end
    
     
 
confusionMatrix
labels

            
                    
                
    
    