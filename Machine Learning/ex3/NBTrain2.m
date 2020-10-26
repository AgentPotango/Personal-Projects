function [conditionTables, priorProb] = NBTrain(AttributeSet, LabelSet)
format long
uniqueConditions = unique(LabelSet);
uniqueAttributes = unique(AttributeSet);
noOfExamples = size(AttributeSet,1);
noOfConditions = size(uniqueConditions,1);
noOfAttributes = size(AttributeSet,2);
noOfAttributeValues = size(uniqueAttributes,1);
noOfUniqueConditions = zeros(1,noOfConditions);
priorProb = zeros(1,noOfConditions);
conditionTables = cell(1,noOfAttributes);

priorEstimate = 1/noOfConditions;
m = 1;
nc = zeros(noOfConditions,noOfAttributeValues);

for i = 1:noOfConditions
    for j = 1:noOfAttributeValues
        nc(i,j) = nc(i,j) + 1;
    end
end

for i = 1:noOfConditions
    noOfUniqueConditions(1,i) = sum(LabelSet == uniqueConditions(i,1));
    priorProb(1,i) = noOfUniqueConditions(1,i)/noOfExamples;
end

for i = 1:noOfAttributes
    conditionTables{1,i} = zeros(noOfAttributeValues,noOfConditions);
end    

%AttributeSet(h,i) =

for h = 1:noOfExamples
    for i= 1:noOfAttributes
        for j = 1:noOfAttributeValues
           if (AttributeSet(h,i) == uniqueAttributes(j,1))
               for k = 1:noOfConditions
                   if (LabelSet(h,1) == uniqueConditions(k,1)) 
                       addValue = 1/noOfUniqueConditions(1,k);
                       conditionTables{1,i}(j,k) = conditionTables{1,i}(j,k) + addValue;
                   end
               end
           end
        end
    end
end

%m-estimate
for i = 1:noOfConditions
    for j = 1:noOfExamples
        for k = 1:noOfAttributes
            for m = 1:noOfAttributeValues
                if (conditionTables{1,k}(m,i) == 0)
                    for n = 1:noOfConditions
                        conditionTables{1,k}(m,n) =  (nc(i,m) + ...
                               (m*priorEstimate))/noOfUniqueConditions(1,i);
                    end
                end
            end
        end
    end
end








